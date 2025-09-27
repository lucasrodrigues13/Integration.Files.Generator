using Integration.Files.Generator.Core.Entities;

namespace Integration.Files.Generator.Core.Strategies.Common
{
    public interface IFileStrategy
    {
        void GenerateFile(IntegrationContext context);
    }
}
