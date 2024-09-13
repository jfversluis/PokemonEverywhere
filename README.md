# Pokémon Everywhere with .NET

Sample code to demonstrate how code can be shared all the way from frontend to backend with C# and .NET.

This project includes:

| Project    | Description |
| -------- | ------- |
| PokemonEverywhere.Blazor | Blazor web app that shows the retrieved Pokémon data coming from the Web API project |
| PokemonEverywhere.Blazor.Shared | Razor Class Library (RCL) that is shared amongst all Blazor enabled projects (Blazor, Blazor Hybrid with .NET MAUI, WPF and WinForms) |
| PokemonEverywhere.BlazorHybrid | Blazor Hybrid project built on .NET MAUI that you can run on Android, iOS, Windows and macOS |
| PokemonEverywhere.Shared | Class library that is shared with **all other projects**. Includes the Pokémon models and services to retrieve data |
| PokemonEverywhere.Vue (not in solution) | A Vue web project that is hosted in the VueHybrid project |
| PokemonEverywhere.VueHybrid | .NET MAUI client project that uses a `HybridWebView` to load a Vue app that then shows the Pokémon data coming from the Web API project |
| PokemonEverywhere.WebAPI | Backend Web API project that retrieves the data from an external source and serves it to the clients |
| PokemonEverywhere.Wpf | WPF client project that shows how to retrieve the data in both a WPF `DataGrid` and using Blazor Hybrid |
| PokemonEverywhere.WinForms | WinForms client project that shows how to retrieve the data in both a WinForms `DataGridView` and using Blazor Hybrid |

## Running the projects

Make sure that the WebAPI project is running to serve the data.

Optionally you can setup a [devtunnel](https://www.youtube.com/watch?v=azuC8SFHWp8) to connect to the server from an emulator/Simulator.

All projects should be able to run through any IDE or code editor or the command-line.

### Running the VueHybrid project

Before running the VueHybrid project make sure to have npm installed and from the **PokemonEverywhere.Vue** folder run

```bash
npm i
npm run build
```
