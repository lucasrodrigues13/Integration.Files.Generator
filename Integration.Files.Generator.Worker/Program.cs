using Integration.Files.Generator.Core.Pipeline;
using Integration.Files.Generator.Core.Steps.Factory;
using Integration.Files.Generator.Core.Strategies;
using Integration.Files.Generator.Worker;

var builder = Host.CreateApplicationBuilder(args);

builder.Services.AddScoped<AxiodisExportFileStrategy>();
builder.Services.AddScoped<MilkVolumeReceivedStrategy>();

builder.Services.AddScoped<IGenerateFileStepFactory, GenerateFileStepFactory>();

builder.Services.AddScoped<PipelineExecutor>();

builder.Services.AddHostedService<Worker>();

var host = builder.Build();
host.Run();
