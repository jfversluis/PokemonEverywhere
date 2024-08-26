using PokemonEverywhere.Shared.Models;
using System.Net.Http.Json;

namespace PokemonEverywhere.Shared.Services;

public class PokemonLocalService
{
    private readonly HttpClient _httpClient;

    public PokemonLocalService(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }
    public async Task<List<Pokemon>> GetPokemonAsync()
    {
        return await _httpClient.GetFromJsonAsync<List<Pokemon>>("/pokemon") ?? [];
    }
    public async Task<Pokemon?> GetPokemonAsync(int id)
    {
        return (await GetPokemonAsync()).FirstOrDefault(p => p.Id == id);
    }
}
