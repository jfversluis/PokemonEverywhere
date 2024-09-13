using PokemonEverywhere.Maui.ViewModels;

namespace PokemonEverywhere.Maui;

public partial class MainPage : ContentPage
{
    private readonly PokemonListViewModel _pokemonListViewModel;
    public MainPage(PokemonListViewModel pokemonListViewModel)
    {
        InitializeComponent();

        _pokemonListViewModel = pokemonListViewModel;
        BindingContext = _pokemonListViewModel;
    }

    protected async override void OnNavigatedTo(NavigatedToEventArgs args)
    {
        base.OnNavigatedTo(args);

        try
        {
            await _pokemonListViewModel.CatchThemAll();
        }
        catch(Exception ex)
        {
            await DisplayAlert("Error catching Pokemon", ex.Message, "OK");
        }
    }
}
