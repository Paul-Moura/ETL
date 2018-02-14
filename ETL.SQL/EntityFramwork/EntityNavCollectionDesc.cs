using System.Collections.Generic;
using System.Reflection;
using System.Reflection.Emit;

namespace ETL.EntityFramwork
{
    public class EntityNavCollectionDesc : EntityNavDescBase
    {
        public EntityNavCollectionDesc(string propName, string typeName, string inverse)
            : base(propName, typeName, inverse) { }

        public override void BuildTypeProperty(TypeBuilder typeBuilder)
        {
            MethodAttributes getSetAttr = MethodAttributes.Public |
                                          MethodAttributes.HideBySig |
                                          MethodAttributes.SpecialName |
                                          MethodAttributes.NewSlot |
                                          MethodAttributes.Virtual;

            var builderType = EntityDesc.TypeBuilders[this.TypeName];
            var listType = typeof(ICollection<>).MakeGenericType(builderType);

            var attrCon = typeof(System.ComponentModel.DataAnnotations.Schema.InversePropertyAttribute)
                .GetConstructor(new[] { typeof(string) });

            var attributeBuilder = new CustomAttributeBuilder(attrCon, new object[] { this.Inverse });

            BuildProperty(typeBuilder,
                this.Name,
                listType,
                getSetAttr,
                new[]
                {
                    attributeBuilder
                });
        }

        protected override string GetHasName()
        {
            return "HasMany";
        }

        protected override string GetWithName()
        {
            return "WithMany";
        }
    }
}