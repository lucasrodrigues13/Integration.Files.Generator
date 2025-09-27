using Integration.Files.Generator.Core.Entities;
using Integration.Files.Generator.Core.Strategies.Common;

namespace Integration.Files.Generator.Core.Strategies
{
    public class AxiodisExportFileStrategy : IFileStrategy
    {
        public void GenerateFile(IntegrationContext context)
        {
            Console.WriteLine(">> File strategy: generating Axiodis file...");
        }
    }
}
