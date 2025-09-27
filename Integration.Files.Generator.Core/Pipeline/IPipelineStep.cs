using Integration.Files.Generator.Core.Entities;

namespace Integration.Files.Generator.Core.Pipeline
{
    public interface IPipelineStep
    {
        Task ExecuteAsync(IntegrationContext context);
    }
}
