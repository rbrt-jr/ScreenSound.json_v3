using System.Collections.Generic;
using System.Text.Json;
namespace ScreenSound_v3.Models;

internal class FavoritesSongs
{
    public string? Name { get; set; }

    public List<Music> ListOfFavoritesSongs { get; }

    public FavoritesSongs(string name)
    {
        this.Name = name;
        ListOfFavoritesSongs = new();
    }

    public void AddFavoritesSongs(Music music)
    {
        ListOfFavoritesSongs.Add(music);
    }

    public void ShowListOfFavoritesSongs()
    {
        Console.WriteLine($"Estas são as músicas favoritas de --> {Name}");
        foreach (var list in ListOfFavoritesSongs)
        {
            Console.WriteLine($"- {list.NomeDaMusica} de {list.NomeDoArtista}");
        }
        Console.WriteLine();
    }

    public void FileGeneratorOfJson()
    {
        string json = JsonSerializer.Serialize(new
        {
            name = Name,
            musics = ListOfFavoritesSongs
        });
        string fileName = $"msuicas-favoritas-{Name}.json";

        File.WriteAllText(fileName, json);
        Console.WriteLine($"Ficheiro json criado com sucesso!{Path.GetFullPath(fileName)}");
    }
}
