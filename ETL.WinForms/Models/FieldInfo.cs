using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using ETL.Annotations;

namespace ETL.Models
{
    public class FieldInfo : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public static implicit operator FieldConfig(FieldInfo o)
        {
            var config = new FieldConfig
            {
                SourceField = o.SourceName,
                Name = o.Name,
                FieldType = o.FieldType,
                Size = o.Size,
                FormulaPattern = o.Formula,
            };

            config.Filters.AddRange(o.Filters);

            return config;
        }

        public static implicit operator FieldInfo(FieldConfig o)
        {
            var config = new FieldInfo
            {
                SourceName = o.SourceField,
                Name = o.Name,
                FieldType = o.FieldType,
                Size = o.Size,
                Formula = o.FormulaPattern,
            };

            config.Filters.AddRange(o.Filters);

            return config;
        }

        private string _sourceName;
        private string _name;
        private FieldType _fieldType;
        private int _size;
        private string _formula;

        public string SourceName
        {
            get => this._sourceName;
            set
            {
                this._sourceName = value;
                this.OnPropertyChanged();
            }
        }

        public string Name
        {
            get => this._name;
            set
            {
                this._name = value;
                this.OnPropertyChanged();
            }
        }

        public FieldType FieldType
        {
            get => this._fieldType;
            set
            {
                this._fieldType = value;
                this.OnPropertyChanged();
            }
        }

        public int Size
        {
            get => this._size;
            set
            {
                this._size = value;
                this.OnPropertyChanged();
            }
        }

        public string Formula
        {
            get => this._formula;
            set
            {
                this._formula = value;
                this.OnPropertyChanged();
            }
        }

        public List<FieldFilter> Filters { get; set; } = new List<FieldFilter>();

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}