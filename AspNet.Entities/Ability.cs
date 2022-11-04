using System;
namespace AspNet.Entities
{
    public class Ability
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Damage { get; set; }

        public int PokemonId { get; set; }
        public Pokemon Pokemon { get; set; }

        public Ability()
        {
        }
    }
}

