using ETL.Controllers;

namespace ETL.Models
{
    public sealed class ImporterInfo
    {
        public ControllerType Type { get; set; }

        public string Name { get; set; }

        public string Source { get; set; }
    }
}