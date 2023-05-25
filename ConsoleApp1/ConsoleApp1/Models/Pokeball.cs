using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using System.ComponentModel;

namespace ConsoleApp1.Models
{
    public class Pokeball
    {
        public Pokemon? PokemonInside { get; set; }
        public bool ContainsPokemon { get; set; }
        public bool PokemonReleased { get; set; }

        public Pokeball(Pokemon? character = null)
        {
            this.PokemonReleased = false;
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

        public bool Use(Trainer trainer)
        {
            
            if (ContainsPokemon && PokemonInside != null)
            {
                if (trainer.IsUsingPokemon)
                {
                    if (trainer.ReleasedPokemon != this.PokemonInside)
                    {
                        Console.WriteLine("This trainer already has a pokemon in the game.");
                        return false;
                    }
                }

                if (PokemonReleased)
                {
                    PokemonReleased = false;
                    trainer.ReleasedPokemon = null;
                    trainer.IsUsingPokemon = false;
                    Console.WriteLine($"\n{trainer.Name} retreated {this.PokemonInside.GetName()}");
                }
                else
                {
                    PokemonReleased = true;
                    trainer.ReleasedPokemon = this.PokemonInside;
                    trainer.IsUsingPokemon = true;
                    Console.WriteLine($"\n{trainer.Name} summoned {this.PokemonInside.GetName()}");
                    this.PokemonInside.DoBattleCry();
                }
                return true;
            }
            else
            {
                return false;
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
