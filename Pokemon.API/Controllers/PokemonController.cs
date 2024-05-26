using Microsoft.AspNetCore.Mvc;
using PokemonAPI.Business.Interfaces;
using System.Threading.Tasks;

namespace PokemonAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PokemonController : ControllerBase
    {
        private readonly IPokemonService _pokemonService;

        public PokemonController(IPokemonService pokemonService)
        {
            _pokemonService = pokemonService;
        }

        [HttpGet("{name}")]
        public async Task<IActionResult> Get(string name)
        {
            var pokemon = await _pokemonService.GetPokemonAsync(name);
            return Ok(pokemon);
        }
    }
}