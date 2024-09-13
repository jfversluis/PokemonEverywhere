using PokemonEverywhere.Shared.Models;
using System.Net.Http.Json;

namespace PokemonEverywhere.Shared.Services;

public class PokemonLocalService(HttpClient httpClient)
{
    private readonly HttpClient _httpClient = httpClient;

    public const string BaseAddress = "https://localhost:7055/";

    public async Task<List<Pokemon>> GetPokemonAsync()
    {
        return await _httpClient.GetFromJsonAsync<List<Pokemon>>("/pokemon") ?? [];
    }
    public async Task<Pokemon?> GetPokemonAsync(int id)
    {
        return (await GetPokemonAsync()).FirstOrDefault(p => p.Id == id);
    }
}
