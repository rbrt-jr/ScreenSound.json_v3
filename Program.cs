using ScreenSound_v3.Models;
using System.Text.Json;
using ScreenSound_v3.Filters;

using (HttpClient client = new HttpClient())

{
    try
    {
        string answere = await client.GetStringAsync("https://guilhermeonrails.github.io/api-csharp-songs/songs.json");

        var musics = JsonSerializer.Deserialize<List<Music>>(answere)!;
        //LinqFilter.FilterAllMusicsGenders(musics);
        //LinqOrder.ShowListOfSortedArtists(musics);
        //LinqFilter.FilterArtistByMusicalGender(musics, "pop");
        //LinqFilter.FilterMusicsByArtist(musics, "U2");
        LinqFilter.musicsFilteredByYear(musics, 2013);

    }
    catch (Exception ex)
    {
        Console.WriteLine($"Houston, we've had a problem: {ex.Message}");
    }

}




