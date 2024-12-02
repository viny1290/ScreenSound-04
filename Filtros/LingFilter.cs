using Modelos;

namespace Filtros;

class LingFilter
{
    public static void FiltrarTodosOsGenerosMusicais(List<Musica> musicas)
    {
        var todosOsGenerosMusicais = musicas.Select(generos => generos.Genero).Distinct().ToList();
        foreach (var item in todosOsGenerosMusicais)
        {
            Console.WriteLine($"- {item}");
        }
    }
}