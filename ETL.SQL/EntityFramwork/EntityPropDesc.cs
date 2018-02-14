using System;

namespace ETL.EntityFramwork
{
    public abstract class EntityPropDesc : EntityPropDescBase
    {
        public Type Type { get; }

        protected EntityPropDesc(string name, Type type)
            : base(name)
        {
            this.Type = type;
        }
    }
}