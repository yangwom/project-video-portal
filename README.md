

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
  <summary> Complete a função <code>ShouldReturnAVideoList</code> para testar seu endpoint </summary>
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
