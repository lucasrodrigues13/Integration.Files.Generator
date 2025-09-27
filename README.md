# Integration Files Generator Worker - POC

## Descrição

Esta é uma **Prova de Conceito (POC)** de uma aplicação **Worker Service** em .NET para gerar arquivos de integração de forma centralizada.  

O objetivo é estudar e aplicar padrões de design como:

- **Chain of Responsibility**: cada etapa do pipeline é um step que processa os dados e passa para o próximo.  
- **Strategy**: cada tipo de arquivo tem uma estratégia de geração específica, permitindo facilmente adicionar novos tipos.  

Atualmente a POC não conecta a banco de dados ou serviços externos, apenas simula os steps com logs no console.  

---

## Funcionalidades da POC

- Pipeline de execução de steps: validação, extração de dados, geração de arquivo, upload.  
- Escolha dinâmica da **strategy** de geração de arquivo com base no parâmetro `FileType`.  
- Uso de **DI (Dependency Injection)** para injetar estratégias e steps.  
- Worker rodando continuamente (simula consumo de fila ou requisições).  

---

## Tecnologias Utilizadas

- .NET 9 (Worker Service)  
- C#  
- Microsoft.Extensions.Hosting  
- Microsoft.Extensions.DependencyInjection  
- Conceitos de design patterns: **Chain of Responsibility** e **Strategy**  

---

## Estrutura do Projeto
```
Integration.Files.Generator
│
├─ Core
│ ├─ Pipeline
│ │ ├─ IPipelineStep.cs
│ │ ├─ IntegrationContext.cs
│ │ └─ PipelineExecutor.cs
│ ├─ Steps
│ │ ├─ ValidateParametersStep.cs
│ │ ├─ ExtractDataStep.cs
│ │ ├─ GenerateFileStep.cs
│ │ ├─ UploadFileStep.cs
│ │ └─ GenerateFileStepFactory.cs
│ └─ Strategies
│ ├─ IFileStrategy.cs
│ ├─ AxiodisExportFileStrategy.cs
│ └─ MilkVolumeReceivedStrategy.cs
│
└─ Worker
└─ Program.cs
└─ Worker.cs
```
---

## Como rodar a POC

1. Clone o repositório.  
2. Abra no Visual Studio ou VS Code.  
3. Execute o projeto **Worker Service**.  
4. O console exibirá logs simulando cada etapa do pipeline:

[Step] Validating parameters...
[Step] Extracting data...
[Step] Generating file...

Strategy: AxiodisExportFileStrategy running...
[Step] Uploading file (simulated)...

yaml
Copiar código

---

## Próximos Passos / Evoluções

- Integrar com **RabbitMQ** para consumo de mensagens de solicitação de geração de arquivos.  
- Persistir informações de execução e status no **SQL Server**.  
- Upload real para **Azure Blob Storage**.  
- Adicionar novos tipos de arquivos criando novas **strategies**.  
- Implementar testes unitários para cada step e strategy.  

---

## Observações

- Esta POC é **para estudo e aprendizado** do padrão Chain of Responsibility e Strategy no contexto de Workers no .NET.  
- Ainda não possui persistência ou integração externa real, apenas simulação via console.  
