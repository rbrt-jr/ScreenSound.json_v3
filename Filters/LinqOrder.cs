using ScreenSound_v3.Models;


namespace ScreenSound_v3.Filters;

internal class LinqOrder
{
    public static void ShowListOfSortedArtists(List<Music> musics)
    {
        var sortedArtists = musics.OrderBy(m => m.NomeDoArtista).Select(m => m.NomeDoArtista).Distinct().ToList();
        Console.WriteLine("Lista ordenada de artistas: ");
        foreach (var artist in sortedArtists)
        {
            Console.WriteLine($"--> {artist}");
        }
    }
}
