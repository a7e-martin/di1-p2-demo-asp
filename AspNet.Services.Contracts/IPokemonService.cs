using AspNet.Entities;

namespace AspNet.Services.Contracts;
public interface IPokemonService
{
    public List<Pokemon> GetPokemons();

    public Pokemon GetPokemon(int id);

    public Pokemon Create(Pokemon pokemon);
}

