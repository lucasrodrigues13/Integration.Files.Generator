using Integration.Files.Generator.Core.Entities.Enums;

namespace Integration.Files.Generator.Core.Steps.Factory
{
    public interface IGenerateFileStepFactory
    {
        GenerateFileStep Create(TypeExportEnum fileType);
    }
}
