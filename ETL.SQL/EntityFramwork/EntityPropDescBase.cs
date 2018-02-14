using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Reflection.Emit;

namespace ETL.EntityFramwork
{
    public abstract class EntityPropDescBase
    {
        internal EntityDesc Parent { get; set; }

        internal FieldBuilder fieldBuilder { get; set; }
        internal MethodBuilder getBuilder { get; set; }
        internal MethodBuilder setBuilder { get; set; }
        internal PropertyBuilder propBuilder { get; set; }

        public string Name { get; }

        internal bool IsMapped { get; set; }

        protected EntityPropDescBase(string name)
        {
            this.Name = name;
        }

        public virtual bool Validate(PropertyInfo[] props)
        {
            return props.All(x => x.Name != this.Name);
        }

        public abstract void BuildTypeProperty(TypeBuilder typeBuilder);

        public abstract void MapEntityProperty(object configEntity);



        protected void BuildProperty(TypeBuilder typeBuilder, string typeName, Type type, MethodAttributes getSetAttr, 
            IEnumerable<CustomAttributeBuilder> attributes)
        {
            fieldBuilder = typeBuilder.DefineField($"<{typeName}>k__BackingField", type, FieldAttributes.Private);

            // Define the "get" accessor method for CustomerName.
            getBuilder = typeBuilder.DefineMethod($"get_{typeName}", getSetAttr, type, Type.EmptyTypes);
            ILGenerator getIL = getBuilder.GetILGenerator();
            getIL.Emit(OpCodes.Ldarg_0);
            getIL.Emit(OpCodes.Ldfld, fieldBuilder);
            getIL.Emit(OpCodes.Ret);

            // Define the "set" accessor method for CustomerName.
            setBuilder = typeBuilder.DefineMethod($"set_{typeName}", getSetAttr, null, new[] { type });
            ILGenerator setIL = setBuilder.GetILGenerator();
            setIL.Emit(OpCodes.Ldarg_0);
            setIL.Emit(OpCodes.Ldarg_1);
            setIL.Emit(OpCodes.Stfld, fieldBuilder);
            setIL.Emit(OpCodes.Ret);

            propBuilder = typeBuilder.DefineProperty(typeName, PropertyAttributes.None, type, null);

            foreach (var attribute in attributes)
            {
                propBuilder.SetCustomAttribute(attribute);
            }

            //propBuilder.SetCustomAttribute(
            //    new CustomAttributeBuilder(
            //        typeof(BrowsableAttribute)
            //            .GetConstructor(new[] {typeof(bool)}),
            //        new object[] {true}
            //    ));

            // Last, we must map the two methods created above to our PropertyBuilder to 
            // their corresponding behaviors, "get" and "set" respectively. 
            propBuilder.SetGetMethod(getBuilder);
            propBuilder.SetSetMethod(setBuilder);
        }

        protected static LambdaExpression ToExpression(Type type, string propName)
        {
            ParameterExpression eParameter = Expression.Parameter(type, "x");
            MemberExpression ePropety = Expression.Property(eParameter, type, propName);
            return Expression.Lambda(ePropety, eParameter);
        }
    }
}