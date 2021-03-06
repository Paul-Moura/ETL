using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using ETL.Annotations;

namespace ETL.Models
{
    public class PageInfo : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public PageInfo(PageConfig config)
        {
            this._sourceName = config.Name;
            if (config.Name != null)
                this.OutputName = FieldNameHelper.Parse(config.Name);

            this.SourceFields = config.Fields.Select(x => x.Name);

            if (config.Fields != null)
            {
                foreach (var configField in config.Fields)
                {
                    this._configs[configField.Name] = configField;
                }
            }
        }

        private readonly Dictionary<string, FieldInfo> _configs = new Dictionary<string, FieldInfo>();

        private string _sourceName;
        private string _outputName;

        public string SourceName
        {
            get => this._sourceName;
            set
            {
                this._sourceName = value;
                this.OnPropertyChanged();
            }
        }

        public string OutputName
        {
            get => this._outputName;
            set
            {
                this._outputName = value;
                this.OnPropertyChanged();
            }
        }

        public IEnumerable<string> SourceFields { get; }

        public FieldInfo[] Fields => this._configs.Values.ToArray();

        /// <summary>
        /// Creates a new <see cref="FieldInfo"/> for the specified source field.
        /// </summary>
        /// <param name="sourceField">The name of the source field.</param>
        /// <returns>The unique name for the output field.</returns>
        public FieldInfo Add(string sourceField)
        {
            var name = sourceField;
            var formula = "$[source]";
            if (string.IsNullOrWhiteSpace(sourceField))
            {
                name =  "NewField";
                formula = "";
            }

            name = this.FormatName(name);

            var config = new FieldInfo
            {
                SourceName = sourceField,
                Name = name,
                FieldType = FieldType.Text,
                Size = 256,
                Formula = formula
            };

            this._configs.Add(config.Name, config);

            return config;
        }

        private string FormatName(string orgName)
        {
            var parsedName = FieldNameHelper.Parse(orgName);

            int i = 1;
            var newName = parsedName;
            while (this._configs.ContainsKey(newName))
            {
                newName = $"{parsedName} ({i++})";
            }

            return newName;
        }

        /// <summary>
        /// Removes a <see cref="FieldInfo"/>.
        /// </summary>
        /// <param name="outputField">The unique output field name.</param>
        /// <returns>Returns true if the <see cref="FieldInfo"/> is successfully removed, otherwise false.</returns>
        public bool Remove(string outputField)
        {
            return this._configs.Remove(outputField);
        }

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}