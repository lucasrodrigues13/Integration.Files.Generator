using Integration.Files.Generator.Core.Entities;
using Integration.Files.Generator.Core.Pipeline;
using Integration.Files.Generator.Core.Steps;
using Integration.Files.Generator.Core.Steps.Factory;

namespace Integration.Files.Generator.Worker
{
    public class Worker : BackgroundService
    {
        private readonly IServiceProvider Services;
        private readonly ILogger<Worker> _logger;

        public Worker( ILogger<Worker> logger, 
            IServiceProvider services)
        {
            _logger = logger;
            Services = services;
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            while (!stoppingToken.IsCancellationRequested)
            {
                _logger.LogInformation("Starting pipeline...");
                using var scope = Services.CreateScope(); // cria escopo
                var executor = scope.ServiceProvider.GetRequiredService<PipelineExecutor>();
                var generateFileStepFactory = scope.ServiceProvider.GetRequiredService<IGenerateFileStepFactory>();

                var context = new IntegrationContext { FileType = Core.Entities.Enums.TypeExportEnum.ExportAxiodis };
                context.Data["ClienteId"] = 123;

                var generateStep = generateFileStepFactory.Create(context.FileType);

                var steps = new List<IPipelineStep>
                {
                    new ValidateParametersStep(),
                    new ExtractDataStep(),
                    generateStep,
                    new UploadFileStep()
                };

                await executor.ExecuteAsync(context, steps);

                _logger.LogInformation("Pipeline finished!");
                await Task.Delay(TimeSpan.FromSeconds(5), stoppingToken);
            }
        }
    }
}
