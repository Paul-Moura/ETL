using System;
using System.Collections.Generic;
using System.Data;

namespace ETL.Models
{
    public sealed class Source
    {
        internal Source(DataTable data)
        {
            this.Data = data ?? throw new ArgumentNullException(nameof(data));

            this.Schema = new SchemaInfo
            {
                Name = data.TableName
            }; 

            foreach (DataColumn col in data.Columns)
            {
                this.Schema.AddField(new SchemaField
                {
                    Name = col.ColumnName,
                    Type = col.DataType
                });
            }
        }

        internal DataTable Data { get; }

        public SchemaInfo Schema { get; }
    }

    public sealed class SchemaInfo
    {
        internal SchemaInfo()
        {
            this._fields = new List<SchemaField>();
        }

        public string Name { get; internal set; }

        private readonly List<SchemaField> _fields;
        public SchemaField[] Fields => this._fields.ToArray();

        internal void AddField(SchemaField field)
        {
            this._fields.Add(field);
        }
    }

    public sealed class SchemaField
    {
        internal SchemaField()
        {
        }

        public string Name { get; internal set; }

        public Type Type { get; internal set; }
    }
}
