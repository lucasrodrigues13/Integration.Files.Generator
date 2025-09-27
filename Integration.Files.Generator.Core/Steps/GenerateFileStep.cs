using Integration.Files.Generator.Core.Entities;
using Integration.Files.Generator.Core.Pipeline;
using Integration.Files.Generator.Core.Strategies.Common;

namespace Integration.Files.Generator.Core.Steps
{
    public class GenerateFileStep : IPipelineStep
    {
        private readonly IFileStrategy _strategy;

        public GenerateFileStep(IFileStrategy strategy)
        {
            _strategy = strategy;
        }

        public Task ExecuteAsync(IntegrationContext context)
        {
            Console.WriteLine("[Step] Generating file...");
            _strategy.GenerateFile(context);
            return Task.CompletedTask;
        }
    }
}
