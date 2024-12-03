using Modelos;

namespace Filtros;

class LinqOrder
{
    public static void ExibirListaDeArtistasOrdenados(List<Musica> musicas)
    {
        var artistasOrdenados = musicas.OrderBy(musicas => musicas.Artista).Select(musicas => musicas.Artista).Distinct().ToList();

        Console.WriteLine("Lista de Artistas Ordenados");
        foreach (var item in artistasOrdenados)
        {
            Console.WriteLine($"- {item}");
        }
    }
}