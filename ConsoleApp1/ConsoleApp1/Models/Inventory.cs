
namespace ConsoleApp1.Models
{
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
                    Console.WriteLine($"Item: {ball.PokemonInside.GetName()}");
                    #pragma warning restore CS8602 // Dereference of a possibly null reference.
                }
                else
                {
                    Console.WriteLine("Item: Empty Pokeball");
                }
            }
        }
        public static void AddToInventory(List<Pokeball> balls)
        {
            for (int i = 0; i < balls.Count; i++)
            {
                var ball = balls[i];
                inventory.Add(ball);
            }
        }
        public static void CreatePokeball(Pokemon? character = null)
        {
            if (character != null)
            {
                Pokeball pokeball = new(character);
                character.IsInPokeball = true;
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
