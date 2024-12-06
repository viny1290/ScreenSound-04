using Modelos;

namespace Filtros;

// Classe que contém métodos relacionados à ordenação de dados utilizando LINQ
class LinqOrder
{
    // Método estático para exibir uma lista ordenada de artistas sem repetições
    public static void ExibirListaDeArtistasOrdenados(List<Musica> musicas)
    {
        // Utiliza LINQ para:
        // 1. Ordenar a lista de músicas pelo nome do artista (`OrderBy`).
        // 2. Selecionar apenas o nome dos artistas (`Select`).
        // 3. Eliminar duplicatas na lista de artistas (`Distinct`).
        // 4. Converter o resultado para uma lista (`ToList`).
        var artistasOrdenados = musicas
            .OrderBy(musica => musica.Artista)
            .Select(musica => musica.Artista)
            .Distinct()
            .ToList();

        // Exibe o título da lista
        Console.WriteLine("Lista de Artistas Ordenados");

        // Itera pela lista de artistas ordenados e os exibe no console
        foreach (var artista in artistasOrdenados)
        {
            Console.WriteLine($"- {artista}");
        }
    }
}