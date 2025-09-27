namespace Integration.Files.Generator.Core.Pipeline
{
    public class PipelineExecutor
    {
        public async Task ExecuteAsync(Entities.IntegrationContext context, IEnumerable<IPipelineStep> steps)
        {
            foreach (var step in steps)
            {
                await step.ExecuteAsync(context);
            }
        }
    }
}
