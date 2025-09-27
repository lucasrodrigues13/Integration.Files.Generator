using Integration.Files.Generator.Core.Entities;
using Integration.Files.Generator.Core.Pipeline;

namespace Integration.Files.Generator.Core.Steps
{
    public class UploadFileStep : IPipelineStep
    {
        public Task ExecuteAsync(IntegrationContext context)
        {
            Console.WriteLine("[Step] Uploading file to Blob (simulated)...");
            return Task.CompletedTask;
        }
    }
}
