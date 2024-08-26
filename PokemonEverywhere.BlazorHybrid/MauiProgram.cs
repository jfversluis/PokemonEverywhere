using Microsoft.Extensions.Logging;
using PokemonEverywhere.Shared.Services;

namespace PokemonEverywhere.BlazorHybrid
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
                });

            builder.Services.AddMauiBlazorWebView();

            builder.Services.AddSingleton<PokemonLocalService>(
                sp => new PokemonLocalService(
                    new HttpClient()
                    {
                        BaseAddress = new Uri("https://localhost:7055/")
                    }));

#if DEBUG
    		builder.Services.AddBlazorWebViewDeveloperTools();
    		builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
