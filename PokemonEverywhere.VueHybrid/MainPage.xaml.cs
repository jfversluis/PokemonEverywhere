using System.Text.Json;
using PokemonEverywhere.Shared.Services;

namespace PokemonEverywhere.VueHybrid;

public partial class MainPage : ContentPage
{
    private readonly PokemonLocalService _pokemonLocalService;

    public MainPage(PokemonLocalService pokemonLocalService)
	{
		InitializeComponent();
		_pokemonLocalService = pokemonLocalService;
		HybridWebView.Loaded += LoadPokemon;
	}

	private async void LoadPokemon(object? sender, EventArgs e)
	{
		var pokemons = await _pokemonLocalService.GetPokemonAsync();
		
		HybridWebView.SendRawMessage(JsonSerializer.Serialize(pokemons));
	}
}

