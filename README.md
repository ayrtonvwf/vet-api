# API VOLTADA A CLÍNICA VETERINÁRIA
Projeto produzido pelo aluno Ayrton Vargas Witcel Fidelis na disciplina de Programação Orientada a Objetos no ano de 2019 - 1º Semestre do Curso de Ciência da Computação, da Universidade Tecnológica Federal do Paraná - UTFPR Medianeira e sob a orientação do professor Everton Coimbra de Araújo.

O aplicativo foi desenvolvido em C# utilizando o Visual Studio Community 2019 (v16.1.4). Para o banco de dados, foi utilizado o ORM (Mapeamento Objeto-Relacional) do Entity framework Core (v2.2.4), usando o MySQL.

**Importante:** Você vai precisar do aplicativo disponível no repositório [vet-app](https://github.com/ayrtonvwf/vet-app) para utilizar esta API.

# Instalação do Visual Studio Community
* Acesse https://visualstudio.microsoft.com/pt-br/vs/community/, selecione a plataforma utilizada (Windows ou MacOS) e clique em "Baixar o visual Studio";
* Instale normalmente, conforme as instruções que seguirem.

# Executando a API
* Vá para https://github.com/ayrtonvwf/vet-api;
* Clique em "Clone or download" e "Download ZIP";
* Descompacte o arquivo baixado e abra a pasta;
* Dentro da pasta, rode o comando: `dotnet ./API/bin/Debug/netcoreapp2.2/API.dll`;
* O sistema irá criar o banco de dados automaticamente e a API ficará aguardando requisições;
* O aplicativo pronto para utilizar esta API pode ser encontrado no repositório [vet-app](https://github.com/ayrtonvwf/vet-app).

# Conteúdo do repositório
O repositório contém as pastas:
* API: Projeto de Web API responsável por receber as requisições;
* Model: Contém as classes base utilizadas, desenvolvidas utilizando o padrão do Entity Framework Core (com ID's, foreign Keys e atributos de navegação);
* Persistencia: Projeto que cuida das configurações e faz a efetiva conexão da aplicação com o banco de dados (MySQL);
* Servico: Projeto intermediário, que faz a ligação entre a API e a persistência;
* EF.sln: Solução da aplicação, usada para gerenciar os projetos.

# IMPORTANTE
* Não foram feitos testes da aplicação em um ambiente real, não havendo portando nenhuma garantia de sua estabilidade.

# Dúvidas ou Sugestões
* Ayrton Vargas Witcel Fidelis - ayrton.vargas33@gmail.com