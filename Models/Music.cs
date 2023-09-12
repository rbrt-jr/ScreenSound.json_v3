using System.Text.Json.Serialization;

namespace ScreenSound_v3.Models;

internal class Music
{
    private string[] tones = { "C", "C#", "D", "Eb", "E", "F", "F#", "G", "Ab", "A", "Bb", "B" };

    [JsonPropertyName("song")]
    public string? NomeDaMusica { get; set; }

    [JsonPropertyName("artist")]
    public string? NomeDoArtista { get; set; }

    [JsonPropertyName("duration_ms")]
    public int Duracao { get; set; }

    [JsonPropertyName("genre")]
    public string? Genero { get; set; }

    [JsonPropertyName("year")]
    public string? AnoString { get; set; }

    [JsonPropertyName("key")]
    public int Key { get; set; }

    public string Tones {
        get
        {
            return tones[Key];
        }
    }

    public int Ano 
    {
        get
        {
            return int.Parse(AnoString!);
        }
    }
    
    public void ShowDatails()
    {
        Console.WriteLine(NomeDoArtista);
        Console.WriteLine(NomeDaMusica);
        Console.WriteLine(Duracao / 1000);
        Console.WriteLine(Genero);
        Console.WriteLine($"Tone: {Tones}");
    }
        
}
