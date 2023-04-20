using ConsoleApp1.Models;
namespace ConsoleApp1.Models
{
    public class Pokeball
    {
        public Character? PokemonInside { get; set; }
        public bool ContainsPokemon { get; set; }

        public Pokeball(Character? character = null)
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
                return $"PokemonName: {PokemonInside.ChosenName}\nType: {PokemonInside.DefaultName} \nStrength: {PokemonInside.Strenght}\nWeakness: {PokemonInside.Weakness}";
            }
            else
            {
                return "This pokeball is empty.";
            }
        }
    }
    public class Inventory
    {
        private static List<Pokeball> inventory = new();
        public static void ShowInventory()
        {
            foreach (Pokeball ball in inventory)
            {
                if (ball.ContainsPokemon)
                {
#pragma warning disable CS8602 // Dereference of a possibly null reference.
                    Console.WriteLine($"Item: {ball.PokemonInside.ChosenName}");
#pragma warning restore CS8602 // Dereference of a possibly null reference.
                }
                else
                {
                    Console.WriteLine("Item: Empty Pokeball");
                }
            }
        }
        public static void CreatePokeball(Character? character = null)
        {
            if (character != null)
            {
                Pokeball pokeball = new(character);
                inventory.Add(pokeball);
            }
            else
            {
                Pokeball pokeball = new();
                inventory.Add(pokeball);
            }
        }
    }

}
