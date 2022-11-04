using System;
using System.Linq;
using AspNet.DAL.Contracts;
using AspNet.Entities;
using Microsoft.EntityFrameworkCore;

namespace AspNet.DAL
{
    public class PokemonRepository : IPokemonRepository
    {
        private PokemonDbContext _context;

        public PokemonRepository(PokemonDbContext context)
        {
            _context = context;
        }

        public Pokemon Create(Pokemon pokemon)
        {
            var entity = _context
                .Set<Pokemon>()
                .Add(pokemon);

            _context.SaveChanges();

            return entity.Entity;
        }

        public List<Pokemon> GetAll()
        {
             return _context
                .Set<Pokemon>()
                .ToList();
        }

        public Pokemon GetOne(int id)
        {
            return _context
                .Set<Pokemon>()
                .Include(x => x.Abilities)
                .FirstOrDefault(x => x.Id == id);
        }

        public Pokemon Update(Pokemon pokemon)
        {
            throw new NotImplementedException();
        }
    }
}

