using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Reflection;
using System.Reflection.Emit;
using System.Threading;

namespace ETL.EntityFramwork
{
    public class EntityDbContext : DbContext
    {
        private const string ASSEMBLY_NAME = "DynamicAssembly";
        private const string ASSEMBLY_FILE = "DynamicAssembly.dll";



        private static readonly Dictionary<string, Type> TypesDictionary;
        private static EntityDesc[] Descriptions;

        static EntityDbContext()
        {
            Database.SetInitializer(new DropCreateDatabaseIfModelChanges<EntityDbContext>());
            TypesDictionary = new Dictionary<string, Type>();
        }

        private static Type GetSetType(string typeName)
        {
            Type type;
            if (TypesDictionary.TryGetValue(typeName, out type))
            {
                return type;
            }
            throw new Exception($"Type {typeName} des not exist.");
        }

        public static bool LoadDll()
        {
            try
            {
                AssemblyName assemblyName = new AssemblyName(ASSEMBLY_NAME);
                var dll = Assembly.Load(assemblyName);
                foreach (var type in dll.GetExportedTypes())
                {
                    TypesDictionary[type.Name] = type;
                }
            }
            catch
            {
                return false;
            }
            return true;
        }

        public static bool ValidateDescriptions(EntityDesc[] descriptions)
        {
            Descriptions = descriptions;

            foreach (var desc in descriptions)
            {
                Type type;
                if (TypesDictionary.TryGetValue(desc.TypeName, out type))
                {
                    PropertyInfo[] props = type.GetProperties(BindingFlags.Public | BindingFlags.Instance);
                    foreach (EntityPropDescBase propDesc in desc.Properties)
                    {
                        if (!propDesc.Validate(props))
                        {
                            return false;
                        }
                    }
                }
                else
                {
                    return false;
                }
            }
            return true;
        }

        public static void Init(EntityDesc[] descriptions)
        {
            Descriptions = descriptions;

            AppDomain myDomain = Thread.GetDomain();
            AssemblyName assemblyName = new AssemblyName(ASSEMBLY_NAME);
            AssemblyBuilder assemblyBuilder = myDomain.DefineDynamicAssembly(assemblyName, AssemblyBuilderAccess.RunAndSave);
            ModuleBuilder moduleBuilder = assemblyBuilder.DefineDynamicModule(ASSEMBLY_NAME, ASSEMBLY_FILE);

            List<EntityDesc> list = new List<EntityDesc>();

            foreach (EntityDesc desc in descriptions)
            {
                if (TypesDictionary.ContainsKey(desc.TypeName)) continue;
                
                desc.BuildType(moduleBuilder, ASSEMBLY_NAME);

                list.Add(desc);
            }

            foreach (EntityDesc desc in list)
            {
                desc.BuildProperties();
            }

            foreach (EntityDesc desc in list)
            {
                Type type = desc.CreateType();
                TypesDictionary.Add(desc.TypeName, type);
            }

            assemblyBuilder.Save(ASSEMBLY_FILE);
        }
        
        private static void MapEntity(DbModelBuilder modelBuilder, EntityDesc desc)
        {
            Type type = TypesDictionary[desc.TypeName];

            object configEntity = Entity(modelBuilder, type);

            //configEntity = ToTable(configEntity, desc.TypeName);

            //foreach (EntityPropDescBase propDesc in desc.Properties)
            //{
            //    propDesc.MapEntityProperty(configEntity);
            //}
        }

        private static object Entity(DbModelBuilder modelBuilder, Type type)
        {
            return typeof(DbModelBuilder)
                .GetMethod("Entity", BindingFlags.Public | BindingFlags.Instance)
                .MakeGenericMethod(type)
                .Invoke(modelBuilder, new object[0]);
        }

        private static object ToTable(object configEntity, string tableName)
        {
            return configEntity.GetType()
                .GetMethod("ToTable", new[] { typeof(string) })
                .Invoke(configEntity, new object[] { tableName });
        }
        


        public static object Create(string typeName)
        {
            var type = GetSetType(typeName);
            return Activator.CreateInstance(type);
        }



        public DbSet this[string typeName] => this.Set(GetSetType(typeName));
        
        public EntityDbContext(string nameOfConnectionString) : base($"name={nameOfConnectionString}") { }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<object>().HasKey()

            foreach (var desc in Descriptions)
            {
                MapEntity(modelBuilder, desc);
            }
        }
    }
}
