# Pokémon Everywhere with .NET

Sample code to demonstrate how code can be shared all the way from frontend to backend with C# and .NET.

This project includes:

| Project    | Description |
| -------- | ------- |
| PokemonEverywhere.Blazor | Blazor web app that shows the retrieved Pokémon data coming from the Web API project |
| PokemonEverywhere.Blazor.Shared | Razor Class Library (RCL) that is shared amongst all Blazor enabled projects (Blazor, Blazor Hybrid with .NET MAUI, WPF and WinForms) |
| PokemonEverywhere.BlazorHybrid | Blazor Hybrid project built on .NET MAUI that you can run on Android, iOS, Windows and macOS |
| PokemonEverywhere.Console | .NET Console application that shows the Pokémon data coming from the Web API project in a table |
| PokemonEverywhere.Maui | .NET MAUI "native" application that shows the Pokémon data coming from the Web API project in a native Android, iOS, Windows and macOS app |
| PokemonEverywhere.Shared | Class library that is shared with **all other projects**. Includes the Pokémon models and services to retrieve data |
| PokemonEverywhere.Vue (not in solution) | A Vue web project that is hosted in the VueHybrid project |
| PokemonEverywhere.VueHybrid | .NET MAUI client project that uses a `HybridWebView` to load a Vue app that then shows the Pokémon data coming from the Web API project |
| PokemonEverywhere.WebAPI | Backend Web API project that retrieves the data from an external source and serves it to the clients |
| PokemonEverywhere.Wpf | WPF client project that shows how to retrieve the data in both a WPF `DataGrid` and using Blazor Hybrid |
| PokemonEverywhere.WinForms | WinForms client project that shows how to retrieve the data in both a WinForms `DataGridView` and using Blazor Hybrid |

## Running the projects

1. Make sure that the WebAPI project is running to serve the data.

    You can do this by running `dotnet run --project PokemonEverywhere.WebApi/PokemonEverywhere.WebApi.csproj --launch-profile "https"`

    If connecting to the https endpoint gives you errors about the certificate being invalid, stop the server and run `dotnet dev-certs https --trust`. This might prompt you for your password. Then run the command above again to run the server.

1. Optionally you can setup a [devtunnel](https://www.youtube.com/watch?v=azuC8SFHWp8) to connect to the server from an emulator/Simulator.

    To do this, [install devtunnels](https://learn.microsoft.com/azure/developer/dev-tunnels/get-started#install) and run `devtunnel host -a -p 7055`. Port 7055 is the default in this project, if you choose to use something else, update the port. Navigate to the generated URL once from a browser to acknowledge the warning message, from then you can connect to the URL from the client app projects.

All projects should be able to run through any IDE or code editor or the command-line.

For example to run the Blazor client project from the command-line use

```bash
dotnet run --project PokemonEverywhere.Blazor/PokemonEverywhere.Blazor.csproj --launch-profile "https"
```

Or to run .NET MAUI on Windows from the command-line use

```bash
dotnet build PokemonEverywhere.Maui/PokemonEverywhere.Maui.csproj -t:Run -f net8.0-windows10.0.19041.0
```

In Visual Studio, set your favorite project as the startup project and start running!

### Running the VueHybrid project

Before running the VueHybrid project make sure to have npm installed and from the **PokemonEverywhere.Vue** folder run

```bash
npm i
npm run build
```
