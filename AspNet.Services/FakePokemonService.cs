using AspNet.Entities;
using AspNet.Services.Contracts;

namespace AspNet.Services;
public class FakePokemonService : IPokemonService
{
    private List<Pokemon> _pokemons;

    public FakePokemonService()
    {
        _pokemons = new List<Pokemon>
        {
            new Pokemon
            {
                Id = 1,
                Name = "Pikachu",
                Type = "Eau",
                Description = "Pokémon volant"
            },
            new Pokemon
            {
                Id = 2,
                Name = "Bulbizarre",
                Type = "Feu",
                Description = "Pokémon de type feu"
            }
        };
    }

    public List<Pokemon> GetPokemons()
    {
        return _pokemons;
    }

    public Pokemon GetPokemon(int id)
    {
        //foreach (var p in _pokemons)
        //{
        //    if (p.Id == id)
        //    {
        //        return p;
        //    }
        //}

        return _pokemons.Find(x => x.Id == id);
    }

    public Pokemon Create(Pokemon pokemon)
    {
        throw new NotImplementedException();
    }
}

