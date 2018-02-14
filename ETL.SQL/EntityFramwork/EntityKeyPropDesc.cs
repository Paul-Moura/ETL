using System;
using System.Linq.Expressions;
using System.Reflection;
using System.Reflection.Emit;

namespace ETL.EntityFramwork
{
    public class EntityKeyPropDesc : EntityPropDesc
    {
        public EntityKeyPropDesc(string name, Type type)
            : base(name, type) { }

        public override void BuildTypeProperty(TypeBuilder typeBuilder)
        {
            MethodAttributes getSetAttr = MethodAttributes.Public |
                                          MethodAttributes.SpecialName |
                                          MethodAttributes.HideBySig;

            var attrCon = typeof(System.ComponentModel.DataAnnotations.KeyAttribute).GetConstructor(Type.EmptyTypes);

            CustomAttributeBuilder attributeBuilder = new CustomAttributeBuilder(attrCon, new object[0]);

            BuildProperty(typeBuilder, this.Name, this.Type, getSetAttr,
                new[] { attributeBuilder });
        }

        public override void MapEntityProperty(object configEntity)
        {
            if (this.IsMapped) return;

            var type = configEntity.GetType();

            LambdaExpression expression = ToExpression(this.Parent.TypeBuilder.CreateType(), this.Name);

            MethodInfo propMethod = type.GetMethod("HasKey");
            propMethod = propMethod.MakeGenericMethod(this.Type);

            propMethod.Invoke(configEntity, new object[] { expression });

            this.IsMapped = true;
        }
    }
}