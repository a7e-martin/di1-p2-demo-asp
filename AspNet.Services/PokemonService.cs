using System;
using AspNet.DAL.Contracts;
using AspNet.Entities;
using AspNet.Services.Contracts;

namespace AspNet.Services
{
    public class PokemonService : IPokemonService
    {
        private IPokemonRepository _repository;

        public PokemonService(IPokemonRepository repository)
        {
            _repository = repository;
        }

        public Pokemon Create(Pokemon pokemon)
        {
            return _repository.Create(pokemon);
        }

        public Pokemon GetPokemon(int id)
        {
            return _repository.GetOne(id);
        }

        public List<Pokemon> GetPokemons()
        {
            return _repository.GetAll();
        }
    }
}

