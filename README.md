# Desafio Softplan 
## Aplicação Web ASP .Net Core, faz cálculo em memória de juros compostos. O projeto possui duas API's:
- TaxaDeJurosAPI: Responde pelo path relativo "/taxaJuros", retornando a taxa juros de 1% ou 0,01;
- CalculaJurosAPI: Responde pelo path relativo "/calculajuros", faz um cálculo em memória de juros compostos. Respondendo também pelo path relativo "/showmethecode" que retorna a url do projeto no github.
 
### Tecnologias utilizadas:
- .Net Cores 3.1
    > NET Core é um framework livre e de código aberto para os sistemas operacionais Windows, Linux e macOS. É um sucessor de código aberto do .NET Framework. O projeto é desenvolvido principalmente pela Microsoft e lançado com a Licença MIT.
- NUnit (.NET Core)
    > O NUnit é um dos frameworks para realização de testes unitários em .NET.
- Swagger (Swashbuckle.AspNetCore)
    > Swagger é uma linguagem de descrição de interface para descrever APIs RESTful expressas usando JSON. O Swagger é usado junto com um conjunto de ferramentas de software de código aberto para projetar, construir, documentar e usar serviços da Web RESTful.

### Requisitos para a compilação do projeto:
- Instalação .Net Core 3.1 SDK.
    > https://dotnet.microsoft.com/download 
- Instalação IDE visual studio.
    > https://code.visualstudio.com/download

### Instruções para a execução do projeto:
- Abrir a IDE do Visual Studio.
- Executar o projeto através <Vários Projetos de Inicialização>(já configurado).
- Pagina inicial da aplicação será aberta no seu navegador padrão, com a documentação Swagger do endpoint para calculo dos juros.

**OU** (para execução dos testes)

- Abrir diretorio da api **TaxaServicoAPI** pelo terminal, rode o comando `dotnet run --project TaxaJurosAPI.csproj`;
- Abrir diretorio da api **CalculaJurosAPI** pelo terminal, rode o comando `dotnet run --project CalculaJurosAPI.csproj`;

### Instruções para a acesso a documentação Swagger:
- Documentação **TaxaServicoAPI**: `http://localhost:5003/documentacao/index.html`;
- Documentação **CalculoJurosAPI**: `http://localhost:5001/documentacao/index.html`;

### Instruções para a execução dos teste unitários:
- Abrir a IDE do Visual Studio.
- Os testes estão localizados na pasta 'Testes', selecionar o teste desejado;
- Clique com o botão direito do mouse, selecione a opção 'Executar Testes'
- O Gerenciador de testes será aberto.
Obs: execute os serviços das api pelo prompt de comando, conforme descrito acima.
