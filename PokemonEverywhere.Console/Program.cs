using ConsoleTables;
using PokemonEverywhere.Shared.Services;

var pokemonService = new PokemonLocalService(
    new HttpClient()
    {
        BaseAddress = new Uri("https://localhost:7055/")
    });

var table = new ConsoleTable("ID", "Name", "Species");

foreach (var pokemon in await pokemonService.GetPokemonAsync())
{
    table.AddRow(pokemon.Id, pokemon.Name, pokemon.Species);
}

table.Write();

Console.ReadLine();