using Modelos;

namespace Filtros;

// Classe que contém métodos para filtragem de dados utilizando LINQ
class LinqFilter
{
    // Método para exibir todos os gêneros musicais distintos presentes na lista de músicas
    public static void FiltrarTodosOsGenerosMusicais(List<Musica> musicas)
    {
        // Utiliza LINQ para:
        // 1. Selecionar o campo 'Genero' de cada objeto `Musica` na lista (`Select`).
        // 2. Eliminar gêneros duplicados da lista (`Distinct`).
        // 3. Converter o resultado para uma lista (`ToList`).
        var todosOsGenerosMusicais = musicas
            .Select(musica => musica.Genero)
            .Distinct()
            .ToList();

        // Exibe cada gênero musical encontrado
        foreach (var genero in todosOsGenerosMusicais)
        {
            Console.WriteLine($"- {genero}");
        }
    }

    // Método para filtrar e exibir os artistas que pertencem a um determinado gênero musical
    public static void FiltrarArtistasPorgeneroMusical(List<Musica> musicas, string genero)
    {
        // Utiliza LINQ para:
        // 1. Filtrar músicas cujo gênero contém o termo especificado (`Where`).
        // 2. Selecionar o campo 'Artista' das músicas filtradas (`Select`).
        // 3. Eliminar artistas duplicados da lista (`Distinct`).
        // 4. Converter o resultado para uma lista (`ToList`).
        var artistasPorGeneroMusical = musicas
            .Where(musica => musica.Genero!.Contains(genero, StringComparison.OrdinalIgnoreCase)) // Busca gênero de forma case-insensitive
            .Select(musica => musica.Artista)
            .Distinct()
            .ToList();

        // Exibe o título indicando o gênero musical filtrado
        Console.WriteLine($"Exibindo os artistas por gênero musical >>>> {genero}");

        // Itera pela lista de artistas filtrados e os exibe no console
        foreach (var artista in artistasPorGeneroMusical)
        {
            Console.WriteLine($"- {artista}");
        }
    }

    public static void FiltrarMusicasDeUmArtista(List<Musica> musicas, string nomeDoArtista)
    {
        var musicasDoArtista = musicas.Where(musica => musica.Artista!.Equals(nomeDoArtista)).ToList();

        Console.WriteLine(nomeDoArtista);
        foreach (var musica in musicasDoArtista)
        {
            Console.WriteLine($"- {musica.Nome}");
        }
    }
}
