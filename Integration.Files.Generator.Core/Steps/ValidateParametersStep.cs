using Integration.Files.Generator.Core.Entities;
using Integration.Files.Generator.Core.Pipeline;

namespace Integration.Files.Generator.Core.Steps
{
    public class ValidateParametersStep : IPipelineStep
    {
        public Task ExecuteAsync(IntegrationContext context)
        {
            Console.WriteLine("[Step] Validating parameters...");
            return Task.CompletedTask;
        }
    }
}
