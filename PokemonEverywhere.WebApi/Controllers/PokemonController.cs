using Microsoft.AspNetCore.Mvc;
using PokemonEverywhere.Shared.Models;
using PokemonEverywhere.Shared.Services;

namespace PokemonEverywhere.WebApi.Controllers;

[ApiController]
[Route("[controller]")]
public class PokemonController : ControllerBase
{
    private readonly ILogger<PokemonController> _logger;
    private readonly PokemonRemoteService _pokemonService;

    public PokemonController(ILogger<PokemonController> logger,
        PokemonRemoteService pokemonService)
    {
        _logger = logger;
        _pokemonService = pokemonService;
    }

    [HttpGet]
    public IEnumerable<Pokemon> Get()
    {
        return _pokemonService.GetPokemonAsync();
    }

    [HttpGet("{id}")]
    public Pokemon? GetById(int id)
    {
        return _pokemonService.GetPokemonAsync(id);
    }
}
