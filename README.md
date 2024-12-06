# 🎵 **SreenSound-04 App**  

Este projeto é um aplicativo console que utiliza LINQ para manipular e exibir dados de músicas. Ele consome uma API JSON para obter uma lista de músicas e oferece funcionalidades para filtrar e ordenar informações, como gêneros musicais e artistas.  

## 📋 **Funcionalidades**  

- **Exibição de gêneros musicais únicos**  
  Lista todos os gêneros musicais disponíveis na base de dados sem repetições.  

- **Filtragem de artistas por gênero musical**  
  Exibe artistas associados a um gênero musical específico.  

- **Listagem de artistas ordenados**  
  Ordena e exibe todos os artistas em ordem alfabética, eliminando duplicatas.  

## 🚀 **Tecnologias Utilizadas**  

- **C#**: Linguagem principal do projeto.  
- **LINQ**: Utilizado para manipulação eficiente de coleções.  
- **.NET**: Framework utilizado para construir a aplicação.  
- **System.Text.Json**: Biblioteca para desserialização de dados JSON.  

## 📂 **Estrutura do Projeto**  

```plaintext
📁 MusicFilteringApp  
├── 📁 Modelos  
│   └── Musica.cs       // Define o modelo de dados para músicas  
├── 📁 Filtros  
│   ├── LinqFilter.cs   // Métodos de filtragem com LINQ  
│   └── LinqOrder.cs    // Métodos de ordenação com LINQ  
├── Program.cs          // Arquivo principal que executa a aplicação  
└── README.md           // Documentação do projeto  

## 🌐 **API Utilizada**  
A aplicação consome dados da seguinte API:  
`https://guilhermeonrails.github.io/api-csharp-songs/songs.json`  

## 💡 **Exemplos de Uso**  

### Listar Todos os Gêneros Musicais  
```csharp
LinqFilter.FiltrarTodosOsGenerosMusicais(musicas);

###Filtrar Artistas por Gênero Musical
```csharp
LinqFilter.FiltrarArtistasPorgeneroMusical(musicas, "rock");

Exibir Artistas Ordenados
```csharp
LinqOrder.ExibirListaDeArtistasOrdenados(musicas);

## 🧑‍💻 **Autor**  

**Vinícius de Vasconcelos Nascimento**  

- [LinkedIn](https://www.linkedin.com/in/vinicius-vasconcelos-a95189200/)  
- [GitHub](https://github.com/viny1290)  