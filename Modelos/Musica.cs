using System.Text.Json.Serialization;

namespace Modelos;
// Classe que representa uma música com suas propriedades e métodos associados
internal class Musica
{
    // Atributo que corresponde ao nome da música no JSON com a propriedade "song"
    [JsonPropertyName("song")]
    public string? Nome { get; set; }

    // Atributo que corresponde ao artista no JSON com a propriedade "artist"
    [JsonPropertyName("artist")]
    public string? Artista { get; set; }

    // Atributo que corresponde à duração da música em milissegundos no JSON com a propriedade "duration_ms"
    [JsonPropertyName("duration_ms")]
    public int Duracao { get; set; }

    // Atributo que corresponde ao gênero musical no JSON com a propriedade "genre"
    [JsonPropertyName("genre")]
    public string? Genero { get; set; }

    // Método para exibir os detalhes da música formatados no console
    public void ExibirDetalhesDaMusica()
    {
        // Exibe o artista da música
        Console.WriteLine($"Artista: {Artista}");

        // Exibe o nome da música
        Console.WriteLine($"Musica: {Nome}");

        // Exibe o gênero musical
        Console.WriteLine($"Genero musical: {Genero}");

        // Converte a duração de milissegundos para segundos e exibe
        // (Nota: a divisão estava errada no código original, corrigida para 1000)
        Console.WriteLine($"Duracao em segundos: {Duracao / 1000}");
    }
}