using System.Text.Json;
using Modelos;
using Filtros;

// Cria um objeto HttpClient para realizar requisições HTTP
using (HttpClient client = new HttpClient())
{
    try
    {
        // Realiza uma requisição GET para obter um JSON de músicas de uma API pública
        string resposta = await client.GetStringAsync("https://guilhermeonrails.github.io/api-csharp-songs/songs.json");

        // Desserializa o JSON obtido na lista de objetos 'Musica'
        var musicas = JsonSerializer.Deserialize<List<Musica>>(resposta)!;

        // Exemplos de métodos para manipular a lista de músicas utilizando LINQ (comentados ou ativados):

        // Filtra todos os gêneros musicais disponíveis na lista de músicas
        // LinqFilter.FiltrarTodosOsGenerosMusicais(musicas);

        // Exibe uma lista de artistas em ordem alfabética
        // LinqOrder.ExibirListaDeArtistasOrdenados(musicas);

        // Filtra artistas com base em um gênero musical específico (neste caso, "rock")
        //LinqFilter.FiltrarArtistasPorgeneroMusical(musicas, "rock");

        //LinqFilter.FiltrarMusicasDeUmArtista(musicas, "Michel Teló");

        var musicasPreferidasDoVinicius = new MusicasPreferidas("Vinicius");
        musicasPreferidasDoVinicius.AdicionarMusicasFavoritas(musicas[1]);
        musicasPreferidasDoVinicius.AdicionarMusicasFavoritas(musicas[377]);
        musicasPreferidasDoVinicius.AdicionarMusicasFavoritas(musicas[13]);
        musicasPreferidasDoVinicius.AdicionarMusicasFavoritas(musicas[6]);
        musicasPreferidasDoVinicius.AdicionarMusicasFavoritas(musicas[1467]);

        musicasPreferidasDoVinicius.ExibirMusicasFavoritas();

        musicasPreferidasDoVinicius.GerarArquivoJson();
    }
    catch (Exception ex) // Captura qualquer exceção que ocorrer durante a execução do código
    {
        // Exibe a mensagem de erro caso algo dê errado
        Console.WriteLine($"Temos um problema: {ex.Message}");
    }
}
