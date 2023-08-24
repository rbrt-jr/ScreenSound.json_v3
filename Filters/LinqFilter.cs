using ScreenSound_v3.Models;
using System.Linq;
namespace ScreenSound_v3.Filters;

internal class LinqFilter
{
    public static void FilterAllMusicsGenders(List<Music> musics)
    {
        var allMusicsGenres = musics.Select(g => g.Genero).Distinct().ToList(); 
        foreach(var genres in allMusicsGenres)
        {
            Console.WriteLine($"-> {genres}");
        }
    }

    public static void FilterArtistByMusicalGender(List<Music> musics, string genre)
    {
        var artitsByMusicalGenre = musics.Where(song => song.Genero!.Contains(genre)).Select(song => song.NomeDoArtista).Distinct().ToList();
        Console.WriteLine($"Exibindo os artistas por gênero musical >>> {genre}");
        foreach (var artist in artitsByMusicalGenre)
        {
            Console.WriteLine($"-- {artist}");
        }

    }

    public static void FilterMusicsByArtist(List<Music> musics, string artistName)
    {
        var musicsFilteredByArtist = musics.Where(m => m.NomeDoArtista!.Equals(artistName)).ToList();
        Console.WriteLine(artistName);
        foreach (var music in musicsFilteredByArtist)
        {
            Console.WriteLine($"- {music.NomeDaMusica}");
        }
    }

    public static void musicsFilteredByYear(List<Music> musics, int year)
    {
        var musicsByYear = musics.Where(m => m.Ano == year).OrderBy(m => m.NomeDaMusica).Select(m => m.NomeDaMusica).Distinct().ToList();
        Console.WriteLine($"Musicas do ano de {year}");
        foreach (var music in musicsByYear)
        {
            Console.WriteLine($"- {music}");
        }
    }
}
