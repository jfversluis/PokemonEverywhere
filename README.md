# Pokemon Everywhere with .NET

Sample code to demonstrate how code can be shared all the way from frontend to backend with C# and .NET.

This project includes:
* A backend Web API service that serves the Pokemon content
* A shared library with the model and 2 services that can be used to retrieve data, **shared by all other projects**
* A shared Razor

| Project    | Description |
| -------- | ------- |
| PokemonEverywhere.Blazor | Blazor web app that shows the retrieved Pokemon data |
| PokemonEverywhere.Blazor.Shared | Razor Class Library (RCL) that is shared amongst all Blazor enabled projects (Blazor, Blazor Hybrid with .NET MAUI, WPF and WinForms) |
| PokemonEverywhere.BlazorHybrid | Blazor Hybrid project built on .NET MAUI that you can run on Android, iOS, Windows and macOS |
| PokemonEverywhere.Shared | Class library that is shared with **all other projects**. Includes the Pokemon models and services to retrieve data |
| PokemonEverywhere.WebAPI | Backend Web API project that retrieves the data from an external source and serves it to the clients |
| PokemonEverywhere.Wpf | WPF client project that shows how to retrieve the data in both a WPF `DataGrid` and using Blazor Hybrid |
| PokemonEverywhere.WinForms | WinForms client project that shows how to retrieve the data in both a WinForms `DataGridView` and using Blazor Hybrid |
