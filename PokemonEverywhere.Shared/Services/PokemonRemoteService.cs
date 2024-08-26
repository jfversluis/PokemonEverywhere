using PokemonEverywhere.Shared.Models;
using System.Text.Json;

namespace PokemonEverywhere.Shared.Services;

public class PokemonRemoteService
{
    private readonly List<Pokemon> _pokemon;

    public PokemonRemoteService(string filePath)
    {
        _pokemon = JsonSerializer.Deserialize<List<Pokemon>>(File.ReadAllText(filePath)) ?? [];
    }

    public List<Pokemon> GetPokemonAsync()
    {
        return _pokemon;
    }

    public Pokemon? GetPokemonAsync(int id)
    {
        return _pokemon.FirstOrDefault(p => p.Id == id);
    }
}
