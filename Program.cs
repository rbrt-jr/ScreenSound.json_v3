using ScreenSound_v3.Models;
using System.Text.Json;
using ScreenSound_v3.Filters;

using (HttpClient client = new HttpClient())

{
    try
    {
        string answere = await client.GetStringAsync("https://guilhermeonrails.github.io/api-csharp-songs/songs.json");

        var musics = JsonSerializer.Deserialize<List<Music>>(answere)!;

        LinqFilter.FilterByKey(musics, "");
        //LinqFilter.FilterAllMusicsGenders(musics);
        //LinqOrder.ShowListOfSortedArtists(musics);
        //LinqFilter.FilterArtistByMusicalGender(musics, "pop");
        //LinqFilter.FilterMusicsByArtist(musics, "U2");
        //LinqFilter.musicsFilteredByYear(musics, 2013);

        //var bobsFavoritesSongs = new FavoritesSongs("Verão23");
        //bobsFavoritesSongs.AddFavoritesSongs(musics[1]);
        //bobsFavoritesSongs.AddFavoritesSongs(musics[377]);
        //bobsFavoritesSongs.AddFavoritesSongs(musics[4]);
        //bobsFavoritesSongs.AddFavoritesSongs(musics[6]);
        //bobsFavoritesSongs.AddFavoritesSongs(musics[1467]);
        //bobsFavoritesSongs.ShowListOfFavoritesSongs();

        //var bobs2 = new FavoritesSongs("Maromba!");
        //bobs2.AddFavoritesSongs(musics[500]);
        //bobs2.AddFavoritesSongs(musics[637]);
        //bobs2.AddFavoritesSongs(musics[428]);
        //bobs2.AddFavoritesSongs(musics[13]);
        //bobs2.AddFavoritesSongs(musics[71]);
        //bobs2.ShowListOfFavoritesSongs();
        //bobs2.FileGeneratorOfJson();




    }
    catch (Exception ex)
    {
        Console.WriteLine($"Houston, we've had a problem: {ex.Message}");
    }

}




