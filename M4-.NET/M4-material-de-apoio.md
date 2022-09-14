# .NET

## Instalação

Instalação através do [site da Microsoft](https://dotnet.microsoft.com/en-us/download).

## CLI

.NET cli é definido pelo comando dotnet:

```shell
dotnet --version
dotnet --list-sdks
dotnet --list-runtimes
dotnet help
```

## Tipos de projeto

- Class library: o resultado final é uma DLL (dynamik-link library) que não possui interface

- Console application: aplicação CLI, pode receber dados, esperar inputs do usuário

- Projeto web: ASP.NET Web, ASP.NET MVC, ASP.NET WebAPI

- Projeto testes: Microsoft Testes

Criando um novo projeto, usando ```dotnet cli```:
 
```csharp
dotnet new console
dotnet new classlib
dotnet new web
dotnet new mvc
dotnet new webapi
dotnet new mstests
```

Gera os arquivos na pasta atual, tem como especificar a pasta:

```csharp
dotnet new console -o <nome>
```

Exemplo de código criado com o comando ```dotnet new console``` na pasta ```./MyApp```.

## Fluxo de execução 

```csharp
dotnet restore // faz o clone de todos os pacotes que a aplicação precisa
dotnet build // compila a aplicação
dotnet clean // limpa as compilações anteriores
dotnet run // compila e executa a aplicação
```

## Variáveis de ambiente

```csharp
dotnet run --environment=${AMBIENTE}
```

## Estrutura do app gerado

- Arquivo .csproj: tem formato XML, contém as definições do projeto (similar ao package.json no Node), e está presente em todo projeto .NET
- Program.cs: é o arquivo principal do C#, a porta de entrada para a aplicação, e será o primeiro arquivo a ser executado.


