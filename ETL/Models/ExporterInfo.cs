using ETL.Controllers;

namespace ETL.Models
{
    public sealed class ExporterInfo
    {
        public ControllerType Type { get; set; }

        public string Name { get; set; }

        public string Source { get; set; }
    }
}