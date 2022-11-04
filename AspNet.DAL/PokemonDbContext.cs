using Microsoft.EntityFrameworkCore;
using AspNet.Entities;

namespace AspNet.DAL;

public class PokemonDbContext : DbContext
{
    public PokemonDbContext(
        DbContextOptions<PokemonDbContext> options
    ) : base(options)
    {

    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<Pokemon>();
        modelBuilder.Entity<Ability>();
    }
}

