using Microsoft.Extensions.Logging;
using PokemonEverywhere.Maui.ViewModels;
using PokemonEverywhere.Shared.Services;

namespace PokemonEverywhere.Maui
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                });

            builder.Services.AddSingleton<PokemonLocalService>(
                sp => new PokemonLocalService(
                    new HttpClient()
                    {
                        BaseAddress = new Uri(PokemonLocalService.BaseAddress)
                    }));

            builder.Services.AddTransient<PokemonListViewModel>();
            builder.Services.AddTransient<MainPage>();

#if DEBUG
            builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
