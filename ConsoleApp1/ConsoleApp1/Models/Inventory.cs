
namespace ConsoleApp1.Models
{
    public class Inventory
    {
        private static List<Pokeball> inventory = new();
        public void ShowInventory()
        {
            foreach (Pokeball ball in inventory)
            {
                if (ball.ContainsPokemon)
                {
                    #pragma warning disable CS8602 // Dereference of a possibly null reference.
                    Console.WriteLine($"Item: {ball.PokemonInside.GetName()}");
                    #pragma warning restore CS8602 // Dereference of a possibly null reference.
                }
                else
                {
                    Console.WriteLine("Item: Empty Pokeball");
                }
            }
        }
        public void AddToInventory(Pokeball pokeball)
        {
            inventory.Add(pokeball);
        }
        public Pokeball CreatePokeball(Pokemon? character = null)
        {
            if (character != null)
            {
                Pokeball pokeball = new(character);
                character.IsInPokeball = true;
                return pokeball;
            }
            else
            {
                Pokeball pokeball = new();
                return pokeball;
            }
        }
    }
}
