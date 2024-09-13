using System.Collections.ObjectModel;
using System.Windows;
using Microsoft.Extensions.DependencyInjection;
using PokemonEverywhere.Shared.Models;
using PokemonEverywhere.Shared.Services;

namespace PokemonEverywhere.Wpf;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    private readonly ServiceProvider serviceProvider;

    public ObservableCollection<Pokemon> Pokemon { get; set; } = new();

    public MainWindow()
    {
        InitializeComponent();

        var serviceCollection = new ServiceCollection();
        serviceCollection.AddSingleton<PokemonLocalService>(
            sp => new PokemonLocalService(
                new System.Net.Http.HttpClient()
                {
                    BaseAddress = new Uri(PokemonLocalService.BaseAddress)
                }));

        serviceCollection.AddWpfBlazorWebView();

        serviceProvider = serviceCollection.BuildServiceProvider();

        Resources.Add("services", serviceProvider);

        DataContext = this;
    }

    private async void Window_Loaded(object sender, RoutedEventArgs e)
    {
        var pokemon = serviceProvider.GetRequiredService<PokemonLocalService>();

        foreach (var p in await pokemon.GetPokemonAsync())
        {
            Pokemon.Add(p);
        }
    }
}