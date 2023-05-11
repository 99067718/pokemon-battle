using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace ConsoleApp1.Models
{
    public class Pokeball
    {
        public Pokemon? PokemonInside { get; set; }
        public bool ContainsPokemon { get; set; }

        public Pokeball(Pokemon? character = null)
        {
            if (character == null)
            {
                ContainsPokemon = false;
            }
            else
            {
                PokemonInside = character;
                ContainsPokemon = true;
            }
        }
        public override string ToString()
        {
            if (ContainsPokemon && PokemonInside != null)
            {
                return "function is currently unavailable"; //$"PokemonName: {PokemonInside.GetName()}\nType: {PokemonInside.DefaultName} \nStrength: {PokemonInside.Strenght}\nWeakness: {PokemonInside.Weakness}";
            }
            else
            {
                return "This pokeball is empty.";
            }
        }
    }
}
