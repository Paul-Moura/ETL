using System.Collections.Generic;
using ETL.Models;

namespace ETL.Controllers
{
    internal class PageConfigController
    {
        private readonly Dictionary<string, FieldConfig> _configs = new Dictionary<string, FieldConfig>();

        public FieldConfig this[string field] => this._configs[field];

        ///// <summary>
        ///// Creates a new <see cref="FieldConfig"/> for the specified source field.
        ///// </summary>
        ///// <param name="sourceField">The name of the source field.</param>
        ///// <returns>The unique name for the output field.</returns>
        //public string Add(string sourceField)
        //{
        //    var config = this.GetNewConfig(sourceField);

        //    this._configs.Add(config.Name, config);

        //    return config.Name;
        //}

        //private FieldConfig GetNewConfig(string sourceField)
        //{
        //    var field = FieldNameHelper.Parse(sourceField); 

        //    int i = 1;
        //    var name = field;
        //    while (this._configs.ContainsKey(name))
        //    {
        //        name = $"{field} ({i++})";
        //    }

        //    return new FieldConfig
        //    {
        //        SourceName = sourceField,
        //        Name = name,
        //        FieldType = FieldType.Text,
        //        Size = 256,
        //        Formula = "[source]"
        //    };
        //}

        ///// <summary>
        ///// Removes a <see cref="FieldConfig"/>.
        ///// </summary>
        ///// <param name="outputField">The unique output field name.</param>
        ///// <returns>Returns true if the <see cref="FieldConfig"/> is successfully removed, otherwise false.</returns>
        //public bool Remove(string outputField)
        //{
        //    return this._configs.Remove(outputField);
        //}
    }
}
