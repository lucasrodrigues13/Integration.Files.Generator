using Integration.Files.Generator.Core.Entities.Enums;
using Integration.Files.Generator.Core.Strategies;
using Integration.Files.Generator.Core.Strategies.Common;
using Microsoft.Extensions.DependencyInjection;


namespace Integration.Files.Generator.Core.Steps.Factory
{
    public class GenerateFileStepFactory : IGenerateFileStepFactory
    {
        private readonly IServiceProvider _serviceProvider;

        public GenerateFileStepFactory(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public GenerateFileStep Create(TypeExportEnum fileType)
        {
            IFileStrategy strategy = fileType switch
            {
                TypeExportEnum.ExportAxiodis => _serviceProvider.GetRequiredService<AxiodisExportFileStrategy>(),
                TypeExportEnum.ExportMilkVolumeReceived => _serviceProvider.GetRequiredService<MilkVolumeReceivedStrategy>(),
                _ => throw new NotSupportedException($"File type '{fileType}' is not supported.")
            };

            return new GenerateFileStep(strategy);
        }
    }

}
