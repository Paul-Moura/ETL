using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Linq;
using System.Reflection;
using System.Reflection.Emit;

namespace ETL.EntityFramwork
{
    public class EntityDesc
    {
        internal static Dictionary<string, EntityDesc> EntityDescs { get; } = new Dictionary<string, EntityDesc>();
        internal static Dictionary<string, TypeBuilder> TypeBuilders { get; } = new Dictionary<string, TypeBuilder>();

        public string TypeName { get; }

        public Collection<EntityPropDescBase> Properties { get; }

        public TypeBuilder TypeBuilder { get; private set; }

        public EntityDesc(string typeName)
        {
            EntityDescs[typeName] = this;

            this.TypeName = typeName;

            var coll = new ObservableCollection<EntityPropDescBase>();
            coll.CollectionChanged += Coll_OnCollectionChanged;
            this.Properties = coll;
        }

        private void Coll_OnCollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
        {
            switch (e.Action)
            {
                case NotifyCollectionChangedAction.Add:
                case NotifyCollectionChangedAction.Reset:
                    foreach (EntityPropDescBase o in e.NewItems)
                    {
                        o.Parent = this;
                    }
                    break;
                case NotifyCollectionChangedAction.Replace:
                case NotifyCollectionChangedAction.Remove:
                case NotifyCollectionChangedAction.Move:
                    foreach (EntityPropDescBase o in e.OldItems)
                    {
                        o.Parent = null;
                    }
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }

        public void BuildType(ModuleBuilder moduleBuilder, string assemblyName)
        {
            this.TypeBuilder = moduleBuilder.DefineType($"{assemblyName}.{this.TypeName}",
                TypeAttributes.Public | 
                TypeAttributes.AutoClass |
                TypeAttributes.AnsiClass |
                TypeAttributes.BeforeFieldInit);

            var attrCon = typeof(System.ComponentModel.DataAnnotations.Schema.TableAttribute).GetConstructor(new[] {typeof(string)});
            var attrBuilder = new CustomAttributeBuilder(attrCon, new object[] {$"EF_{this.TypeName}"});
            this.TypeBuilder.SetCustomAttribute(attrBuilder);

            TypeBuilders[this.TypeName] = this.TypeBuilder;
        }

        public void BuildProperties()
        {
            foreach (var propDesc in this.Properties)
            {
                propDesc.BuildTypeProperty(this.TypeBuilder);
            }
        }
        
        public Type CreateType()
        {
            var constructorBuilder = this.TypeBuilder.DefineConstructor(MethodAttributes.Public | 
                MethodAttributes.HideBySig |
                MethodAttributes.SpecialName |
                MethodAttributes.RTSpecialName, CallingConventions.HasThis, Type.EmptyTypes);
            var conIL = constructorBuilder.GetILGenerator();
            conIL.Emit(OpCodes.Ldarg_0);
            conIL.Emit(OpCodes.Call, typeof(object).GetConstructor(Type.EmptyTypes));

            foreach (EntityNavDescBase nav in this.Properties.Where(x => x is EntityNavDescBase))
            {
                ConstructorInfo genericCon = typeof(HashSet<>).GetConstructor(Type.EmptyTypes);
                Type listType = typeof(HashSet<>).MakeGenericType(TypeBuilders[nav.TypeName]);

                var typeCon = TypeBuilder.GetConstructor(listType, genericCon);

                conIL.Emit(OpCodes.Ldarg_0);
                conIL.Emit(OpCodes.Newobj, typeCon);
                conIL.Emit(OpCodes.Callvirt, nav.setBuilder);
            }

            conIL.Emit(OpCodes.Ret);

            return this.TypeBuilder.CreateType();
        }
    }
}
