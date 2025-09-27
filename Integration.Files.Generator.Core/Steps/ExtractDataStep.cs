using Integration.Files.Generator.Core.Entities;
using Integration.Files.Generator.Core.Pipeline;

namespace Integration.Files.Generator.Core.Steps
{
    public class ExtractDataStep : IPipelineStep
    {
        public Task ExecuteAsync(IntegrationContext context)
        {
            Console.WriteLine("[Step] Extracting data from system...");
            return Task.CompletedTask;
        }
    }
}
