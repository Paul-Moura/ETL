using System.Linq;
using System.Linq.Expressions;

namespace ETL.EntityFramwork
{
    public abstract class EntityNavDescBase : EntityPropDescBase
    {
        public string TypeName { get; }

        public string Inverse { get; }

        protected EntityNavDescBase(string propName, string typeName, string inverse)
            : base(propName)
        {
            this.TypeName = typeName;
            this.Inverse = inverse;
        }

        public override void MapEntityProperty(object configEntity)
        {
            if (this.IsMapped) return;

            var configProperty = this.Has(configEntity,
                this.GetHasName(),
                ToExpression(this.Parent.TypeBuilder.CreateType(), this.Name));

            this.IsMapped = true;

            EntityNavDescBase inverse = EntityDesc.EntityDescs[this.TypeName]
                .Properties.FirstOrDefault(x => x.Name == this.Inverse) as EntityNavDescBase;

            if (inverse?.IsMapped ?? true) return;

            inverse.With(configProperty,
                inverse.GetWithName(),
                ToExpression(inverse.Parent.TypeBuilder.CreateType(), this.Inverse));

            inverse.IsMapped = true;
        }

        protected abstract string GetHasName();

        protected abstract string GetWithName();

        protected object Has(object configEntity, string methodName, LambdaExpression expression)
        {
            var method = configEntity.GetType().GetMethod(methodName);
            method = method.MakeGenericMethod(EntityDesc.TypeBuilders[this.TypeName].CreateType());

            return method.Invoke(configEntity, new object[] { expression });
        }

        protected object With(object configProperty, string methodName, LambdaExpression expression)
        {
            var method = configProperty.GetType().GetMethods().First(x => x.Name == methodName);

            return method.Invoke(configProperty, new object[] { expression });
        }
    }
}