using PokemonEverywhere.Shared.Models;
using PokemonEverywhere.Shared.Services;
using System.Collections.ObjectModel;

namespace PokemonEverywhere.Maui.ViewModels;

public class PokemonListViewModel(PokemonLocalService pokemonLocalService)
{
    private readonly PokemonLocalService pokemonLocalService = pokemonLocalService;

    public ObservableCollection<Pokemon> Pokemon { get; } = [];

    public async Task CatchThemAll()
    {
        var pokemon = await pokemonLocalService.GetPokemonAsync();

        Pokemon.Clear();

        foreach (var p in pokemon)
        {
            Pokemon.Add(p);
        }
    }
}
