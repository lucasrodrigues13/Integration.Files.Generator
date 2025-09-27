using Integration.Files.Generator.Core.Entities.Enums;

namespace Integration.Files.Generator.Core.Entities
{
    public class IntegrationContext
    {
        public TypeExportEnum FileType { get; set; }
        public Dictionary<string, object> Data { get; set; } = new();
    }

}
