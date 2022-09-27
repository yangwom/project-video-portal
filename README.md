# Boas-vindas ao repositório do exercício Portal de Vídeos

Para realizar o projeto, atente-se a cada passo descrito a seguir. Se tiver qualquer dúvida, nos envie por _Slack_! #vqv 🚀

Aqui você vai encontrar os detalhes de como estruturar o desenvolvimento do seu projeto a partir deste repositório, utilizando uma branch específica e um _Pull Request_ para colocar seus códigos.

# Termos e acordos

Ao iniciar este projeto, você concorda com as diretrizes do Código de Conduta e do Manual da Pessoa Estudante da Trybe.

# Orientações

<details>
  <summary><strong>‼️ Antes de começar a desenvolver</strong></summary><br />

  1. Clone o repositório

  - Use o comando: `git clone git@github.com:tryber/acc-csharp-0x-project/exercises-<ATUALIZAR>.git`.
  - Entre na pasta do repositório que você acabou de clonar:
    - `cd acc-csharp-0x-project/exercises-<ATUALIZAR>`

  2. Instale as dependências
  
  - Entre na pasta `src/`.
  - Execute o comando: `dotnet restore`.
  
  3. Crie uma branch a partir da branch `master`

  - Certifique-se de que você está na branch `master`
    - Exemplo: `git branch`
  - Se não estiver, mude para a branch `master`
    - Exemplo: `git checkout master`
  - Agora crie uma branch à qual você vai submeter os `commits` do seu projeto
    - Você deve criar uma branch no seguinte formato: `nome-de-usuario-nome-do-projeto`
    - Exemplo: `git checkout -b joaozinho-acc-0x-project/exercises-<ATUALIZAR>`

  4. Adicione as mudanças ao _stage_ do Git e faça um `commit`

  - Verifique que as mudanças ainda não estão no _stage_
    - Exemplo: `git status` (deve aparecer listada a pasta _joaozinho_ em vermelho)
  - Adicione o novo arquivo ao _stage_ do Git
    - Exemplo:
      - `git add .` (adicionando todas as mudanças - _que estavam em vermelho_ - ao stage do Git)
      - `git status` (deve aparecer listado o arquivo _joaozinho/README.md_ em verde)
  - Faça o `commit` inicial
    - Exemplo:
      - `git commit -m 'iniciando o projeto x'` (fazendo o primeiro commit)
      - `git status` (deve aparecer uma mensagem tipo essa: _nothing to commit_ )

  5. Adicione a sua branch com o novo `commit` ao repositório remoto

  - Usando o exemplo anterior: `git push -u origin joaozinho-acc-0x-project/exercises-<ATUALIZAR>`

  6. Crie um novo `Pull Request` _(PR)_

  - Vá até a página de _Pull Requests_ do [repositório no GitHub](https://github.com/tryber/acc-csharp-0x-project/exercises-<ATUALIZAR>/pulls)
  - Clique no botão verde _"New pull request"_
  - Clique na caixa de seleção _"Compare"_ e escolha a sua branch **com atenção**
  - Coloque um título para a sua _Pull Request_
    - Exemplo: _"Cria tela de busca"_
  - Clique no botão verde _"Create pull request"_
  - Adicione uma descrição para o _Pull Request_ e clique no botão verde _"Create pull request"_
  - **Não se preocupe em preencher mais nada por enquanto!**
  - Volte até a [página de _Pull Requests_ do repositório](https://github.com/tryber/acc-csharp-0x-project/exercises-<ATUALIZAR>/pulls) e confira que o seu _Pull Request_ está criado

</details>

<details>
  <summary><strong>⌨️ Durante o desenvolvimento</strong></summary><br/>

  - Faça `commits` das alterações que você fizer no código regularmente

  - Lembre-se sempre de, após um (ou alguns) `commits`, atualizar o repositório remoto

  - Os comandos que você utilizará com mais frequência são:
    1. `git status` _(para verificar o que está em vermelho - fora do stage - e o que está em verde - no stage)_
    2. `git add` _(para adicionar arquivos ao stage do Git)_
    3. `git commit` _(para criar um commit com os arquivos que estão no stage do Git)_
    4. `git push -u origin nome-da-branch` _(para enviar o commit para o repositório remoto na primeira vez que fizer o `push` de uma nova branch)_
    5. `git push` _(para enviar o commit para o repositório remoto após o passo anterior)_

</details>

<details>
  <summary><strong>🤝 Depois de terminar o desenvolvimento (opcional)</strong></summary><br/>

  Para sinalizar que o seu projeto está pronto para o _"Code Review"_, faça o seguinte:

  - Vá até a página **DO SEU** _Pull Request_, adicione a label de _"code-review"_ e marque seus colegas:

    - No menu à direita, clique no _link_ **"Labels"** e escolha a _label_ **code-review**;

    - No menu à direita, clique no _link_ **"Assignees"** e escolha **o seu usuário**;

    - No menu à direita, clique no _link_ **"Reviewers"** e digite `students`, selecione o time `tryber/students-sd-0x`.

  Caso tenha alguma dúvida, [aqui tem um vídeo explicativo](https://vimeo.com/362189205).

</details>

<details>
  <summary><strong>🕵🏿 Revisando um pull request</strong></summary><br />

  Use o conteúdo sobre [Code Review](https://app.betrybe.com/course/real-life-engineer/code-review) para te ajudar a revisar os _Pull Requests_.

</details>

<details>
  <summary><strong>🎛 Linter</strong></summary><br />

  Usaremos o [NetAnalyzer](https://docs.microsoft.com/pt-br/dotnet/fundamentals/code-analysis/overview) para fazer a análise estática do seu código.

  Este projeto já vem com as dependências relacionadas ao _linter_ configuradas no arquivo `.csproj`.

  O analisador já é instalado pelo plugin da `Microsoft C#` no `VSCode`. Para isso, basta fazer o download do [plugin](https://marketplace.visualstudio.com/items?itemName=ms-dotnettools.csharp) e instalá-lo.
</details>

<details>
  <summary><strong>🛠 Testes</strong></summary><br />

  O .NET já possui sua própria plataforma de testes.
  
  Este projeto já vem configurado e com suas dependências.

  ### Executando todos os testes

  Para executar os testes com o .NET, execute o comando dentro do diretório do seu projeto `src/<project>` ou de seus testes `src/<project>.Test`!

  ```
  dotnet test
  ```

  ### Executando um teste específico

  Para executar um teste específico, basta executar o comando `dotnet test --filter Name~TestMethod1`.

  :warning: **Importante:** o comando irá executar testes cujo nome contém `TestMethod1`.

  :warning: **O avaliador automático não necessariamente avalia seu projeto na ordem em que os requisitos aparecem no readme. Isso acontece para deixar o processo de avaliação mais rápido. Então, não se assuste se isso acontecer, ok?**

  ### Outras opções para testes
  - Algumas opções que podem lhe ajudar são:
    -  `-?|-h|--help`: exibe a descrição completa de como utilizar o comando.
    -  `-t|--list-tests`: lista todos os testes, ao invés de executá-los.
    -  `-v|--verbosity <LEVEL>`: define o nível de detalhe na resposta dos testes.
      - `q | quiet`
      - `m | minimal`
      - `n | normal`
      - `d | detailed`
      - `diag | diagnostic`
      - Exemplo de uso: 
         ```
           dotnet test -v diag
         ```
         ou
         ```            
           dotnet test --verbosity=diagnostic
         ``` 
</details>

<details>
  <summary><strong>🗣 Nos dê feedbacks sobre o projeto!</strong></summary><br />

Ao finalizar e submeter o projeto, não se esqueça de avaliar sua experiência preenchendo o formulário. 
**Leva menos de 3 minutos!**

[FORMULÁRIO DE AVALIAÇÃO DE PROJETO](https://be-trybe.typeform.com/to/ZTeR4IbH)

</details>

<details>
  <summary><strong>🗂 Compartilhe seu portfólio!</strong></summary><br />

  Você sabia que o LinkedIn é a principal rede social profissional e que compartilhar aprendizados lá é muito importante para quem deseja construir uma carreira de sucesso? Compartilhe este projeto no seu LinkedIn, marque o perfil da Trybe (@trybe) e mostre para a sua rede toda a sua evolução.

</details>

# Requisitos

Olá, Tryber!  

Sua empresa recebeu uma encomenda de um cliente, a criação de uma api que controle um portal de vídeos. 

Você recebeu algumas _tasks_ neste projeto, e chegou a hora de você pôr em prática todos os seus aprendizados de banco de dados! 

> ⚠️ **IMPORTANTE:** ⚠️ Para que os testes deste projeto sejam executados, será necessária a implementação do primeiro requisito de forma completa, pois é nele que serão criadas algumas propriedades que são utilizadas nos testes.
> Todos os testes em `video-poral.Test/` deste projeto contêm dados de entrada de exemplo.

## 1 - Implemente os Models da aplicação 

<details>
  <summary>Implemente os Models da aplicação seguindo as recomendações</summary>
  <br />

Crie um novo arquivo para cada `Model` na pasta `src/video-portal/Models`. Todos devem fazer parte do _namespace_ `video_portal.Models`.

  <details>
    <summary>Implemente o Model <code>Channel</code></summary>
    <br />
    
Channel deve conter os seguintes campos:
- `ChannelId`: Chave primária (int)
- `ChannelName`: string
- `ChannelDescription`: string (anulável)
- `Url`: string

Cada canal tem vários vídeos e várias pessoas usuárias. A propriedade de navegação para `Video` deve se chamar `Videos` e para `User` deve ser `Owners`.
  </details>

  <details>
    <summary>Implemente o Model <code>Comment</code></summary>
    <br />
    
Comment deve conter os seguintes campos:
- `CommentId`: Chave primária (int)
- `CommentText`: string
- `VideoId`: chave estrangeira para vídeos
- `UserId`: chave estrangeira para pessoas usuárias

Cada commentário pertence a um vídeo e a uma pessoa usuária.
  </details>

  <details>
    <summary>Implemente o Model <code>User</code></summary>
    <br />
    
User deve conter os seguintes campos:
- `UserId`: Chave primária (int)
- `Username`: string
- `Email`: string

Cada pessoa usuária tem vários canais. A propriedade de navegação para `Channel` deve se chamar `Channels`.
Cada pessoa usuária tem vários comentários. A propriedade de navegação para `Comment` deve ser chamar `Comments`.
  </details>

  <details>
    <summary>Implemente o Model <code>Video</code></summary>
    <br />
    
Vídeo deve conter os seguintes campos:
- `VideoId`: Chave primária (int)
- `Title`: string
- `Description`: string (anulável)
- `Url`: string
- `ChannelId`: chave estrangeira para `Channel`

Cada vídeo tem vários comentários. A propriedade de navegação para `Comment` deve se chamar `Comments`.
  </details>
</details>

## 2 - Implemente o contexto de banco de dados

<details>
  <summary>O contexto deve conter todos os <i>Models</i> da aplicação</summary>
  <br />

Finalize a implementação do contexto da aplicação no arquivo `src/video-portal/Repository/VideoPortalContext.cs`.

Faça um `override` do método `OnConfiguring` para o contexto se conectar ao seu banco de dados local.

Caso você queira executar o seu projeto para testar localmente, em `/src` também está o arquivo docker-compose.yml com um banco SqlServer. Caso você queira usar essa base, tenha o Docker e o docker-compose instalado na sua máquina!

Você pode criar as tabelas do banco de dados atráves do comando `dotnet ef database update`. Caso você execute esse comando, certifique-se de que o CLI do Entity Framework esteja instalado na sua máquina!

</details>

## 3 - Implemente o repositório

<details>
  <summary> Você deve finalizar a implementação da interface <code>IVideoPortalRepository</code></summary>
  <br />

Finalize a implementação do repositório no arquivo `src/video-portal/Repository/VideoPortalRepository.cs`. Esse repositório deve utilizar o contexto criado no requisito anterior para realizar as operações no banco de dados. 

Os métodos a ser implementados são:
 - `GetVideoById`
 - `GetVideos`
 - `GetChannelById`
 - `GetChannels`
 - `GetVideosByChannelId`
 - `GetCommentsByVideoId`
 - `DeleteChannel`
    - Deve deletar apenas se o canal não tiver vídeos. Caso tenha uma exceção, deve ser lançada do tipo `InvalidOperationException`.
 - `AddVideoToChannel`
    - Caso o canal ou o vídeo não existam, uma exceção do tipo `InvalidOperationException` deve ser lançada.

Você pode escolher uma das técnicas de carregamento aprendidas: Eager Loading, Lazy Loading ou Explicit Loading.
</details>

<details>
  <summary>Teste o seu repositório</summary>
  <br />

  Finalize a implementação dos testes no arquvio `src/video-portal.Test/VideoPortalRepositoryTest.cs`. Esses testes devem utilizar o `repository` já instanciado no arquivo. 

  Os testes a serem implementados são:
 - `ShouldGetVideoById`
 - `ShouldGetVideos`
 - `ShouldGetChannelById`
 - `ShouldGetChannels`
 - `ShouldGetVideosByChannelId`
 - `ShouldGetCommentsByVideoId`
 - `ShouldDeleteChannel`
 - `ShouldAddVideoToChannel`


Já existe um teste implementado, o `ShouldAddVideoToChannel`. Entenda como ele funciona e tente aplicar para os demais!

> ⚠️ **IMPORTANTE:** ⚠️ Para o avaliador avaliar os seus testes, você deve utilizar os parâmetros recebidos nos métodos dos testes para realizar a validação.
> Foi criada a função `GetContextInstanceForTests` no arquivo `src/video-portal.Test/Helpers.cs` que recebe como parâmetro um nome para o banco de dados em memória que será utilizado e retorna uma instância de `VideoPortalContext` com alguns dados inseridos inicialmente. Tenha em mente esses dados inseridos no banco de dados inicialmente para realizar os seus testes.
> 
> Os dados são inseridos utilizando as funções `GetCommentListForTests`, `GetVideoListForTests` e `GetChannelListForTests`. 
> Se quiser que os dados em seus testes sejam diferentes, modifique o retorno dessas funções, porém tenha em mente que os **dados de entrada para os testes precisam refletir a mudança.**
> 
> Lembre-se de que os testes, ao realizar operações no repositório, podem alterar os dados no banco de dados. Por esse motivo, é importante que cada teste utilize um banco de dados em memória de nome diferente. Assim você estará garantindo que os testes não influenciam um nos outros.

</details>

## 4 - Teste a listagem de vídeo

<details>
  <summary> Complete a função <code>ShouldReturnAVideoLis</code> para testar seu endpoint </summary>
  <br />

A função se encontra no arquivo `src/video-portal.Test/VideoPortalTest.cs`.

O seu teste deve realizar uma requisição `GET` para o endpoint `api/video` e verificar se o retorno condiz com a lista de vídeos recebida como parâmetro.

</details>

## 5 - Teste a listagem do canal

<details>
  <summary> Complete a função <code>ShouldReturnAChannelWithVideos</code> para testar seu endpoint </summary>
  <br />

A função se encontra no arquivo `src/video-portal.Test/VideoPortalTest.cs`.

O seu teste deve realizar uma requisição `GET` para o endpoint `/api/channel/{id}/video` utilizando o `Channel` recebido como parâmetro e verificar se o retorno condiz com a lista de vídeos recebida como parâmetro.

</details>


Divirta-se e boa sorte! 
