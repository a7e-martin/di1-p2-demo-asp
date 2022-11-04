using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using AspNet.Entities;
using AspNet.Services.Contracts;

namespace AspNet.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PokemonController : ControllerBase
    {
        private IPokemonService _service;

        public PokemonController(IPokemonService pokemonService)
        {
            _service = pokemonService;
        }

        [HttpGet]
        public IEnumerable<Pokemon> Get()
        {
            return _service.GetPokemons();
        }

        [HttpGet("{id}")]
        public Pokemon GetOne(int id)
        {
            return _service.GetPokemon(id);
        }

        [HttpPost]
        public Pokemon Create([FromBody]Pokemon pokemon)
        {
            return _service.Create(pokemon);

        }
    }
}
