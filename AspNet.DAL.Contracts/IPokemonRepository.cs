using AspNet.Entities;

namespace AspNet.DAL.Contracts;


public interface IPokemonRepository
{
    public List<Pokemon> GetAll();

    public Pokemon GetOne(int id);

    public Pokemon Create(Pokemon pokemon);

    public Pokemon Update(Pokemon pokemon);
}

