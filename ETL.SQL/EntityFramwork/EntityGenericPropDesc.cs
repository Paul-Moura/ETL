using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Reflection.Emit;

namespace ETL.EntityFramwork
{
    public class EntityGenericPropDesc : EntityPropDesc
    {
        public EntityGenericPropDesc(string name, Type type)
            : base(name, type) { }

        public override void BuildTypeProperty(TypeBuilder typeBuilder)
        {
            MethodAttributes getSetAttr = MethodAttributes.Public |
                                          MethodAttributes.SpecialName |
                                          MethodAttributes.HideBySig;

            BuildProperty(typeBuilder, this.Name, this.Type, getSetAttr, new CustomAttributeBuilder[0]);
        }

        public override void MapEntityProperty(object configEntity)
        {
            if (this.IsMapped) return;

            var type = configEntity.GetType();

            LambdaExpression expression = ToExpression(this.Parent.TypeBuilder.CreateType(), this.Name);

            MethodInfo propMethod = type
                .GetMethod("Property", new[] { expression.GetType() });

            if (propMethod == null)
            {
                MethodInfo[] allMethods = type
                    .GetMethods(BindingFlags.Public | BindingFlags.Instance);

                IEnumerable<MethodInfo> propMethods = allMethods
                    .Where(x => x.Name == "Property" && x.IsGenericMethodDefinition);

                Type genericMethodType = this.Type.IsNullableType()
                    ? this.Type.GetUnderlyingType()
                    : this.Type;

                foreach (MethodInfo info in propMethods)
                {
                    try
                    {
                        propMethod = info.MakeGenericMethod(genericMethodType);
                        propMethod.Invoke(configEntity, new object[] { expression });
                        break;
                    }
                    catch (Exception e)
                    {
                        propMethod = null;
                    }
                }
            }
            else
            {
                propMethod.Invoke(configEntity, new object[] { expression });
            }

            if (propMethod == null)
                throw new Exception($"Property could not be mapped - {this.Name}");

            this.IsMapped = true;
        }
    }
}