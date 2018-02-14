using System;
using System.Reflection;
using System.Reflection.Emit;

namespace ETL.EntityFramwork
{
    public class EntityNavDesc : EntityNavDescBase
    {
        public Type ForeginKeyType { get; }

        public EntityNavDesc(string propName, string typeName, Type foreginKeyType, string inverse)
            : base(propName, typeName, inverse)
        {
            ForeginKeyType = foreginKeyType;
        }

        public override void BuildTypeProperty(TypeBuilder typeBuilder)
        {
            MethodAttributes getSetAttr = MethodAttributes.Public |
                                          MethodAttributes.HideBySig |
                                          MethodAttributes.SpecialName;

            ConstructorInfo attrCon = typeof(System.ComponentModel.DataAnnotations.Schema.ForeignKeyAttribute)
                .GetConstructor(new[] { typeof(string) });

            CustomAttributeBuilder attributeBuilder = new CustomAttributeBuilder(attrCon, new object[] { this.Name });

            this.BuildProperty(typeBuilder, $"{this.Name}Id", this.ForeginKeyType, getSetAttr,
                new[] { attributeBuilder });

            attrCon = typeof(System.ComponentModel.DataAnnotations.Schema.InversePropertyAttribute)
                .GetConstructor(new[] { typeof(string) });

            attributeBuilder = new CustomAttributeBuilder(attrCon, new object[] { this.Inverse });

            var type = EntityDesc.TypeBuilders[this.TypeName];

            BuildProperty(typeBuilder,
                this.Name,
                type,
                getSetAttr | MethodAttributes.NewSlot | MethodAttributes.Virtual,
                new[] { attributeBuilder });
        }

        protected override string GetHasName()
        {
            return this.ForeginKeyType.IsNullableType()
                ? "HasOptional"
                : "HasRequired";
        }

        protected override string GetWithName()
        {
            return this.ForeginKeyType.IsNullableType()
                ? "WithRequired"
                : "WithOptional";
        }
    }
}