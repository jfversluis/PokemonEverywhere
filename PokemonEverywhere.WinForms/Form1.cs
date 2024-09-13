using Microsoft.AspNetCore.Components.WebView.WindowsForms;
using Microsoft.Extensions.DependencyInjection;
using PokemonEverywhere.Shared.Services;

namespace PokemonEverywhere.WinForms;

public partial class Form1 : Form
{
    private readonly ServiceProvider serviceProvider;

    public Form1()
    {
        InitializeComponent();

        var services = new ServiceCollection();
        services.AddWindowsFormsBlazorWebView();
        services.AddSingleton<PokemonLocalService>(
            sp => new PokemonLocalService(
                new HttpClient()
                {
                    BaseAddress = new Uri(PokemonLocalService.BaseAddress)
                }));

        serviceProvider = services.BuildServiceProvider();

        blazorWebView1.HostPage = "wwwroot\\index.html";
        blazorWebView1.Services = serviceProvider;
        blazorWebView1.RootComponents.Add<PokemonPage>("#app");
    }

    private async void Form1_Load(object sender, EventArgs e)
    {
        var pokemon = serviceProvider.GetRequiredService<PokemonLocalService>();

        dataGridView1.DataSource = await pokemon.GetPokemonAsync();
    }
}
