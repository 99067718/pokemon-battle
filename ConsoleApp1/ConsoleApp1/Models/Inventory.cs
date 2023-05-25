
namespace ConsoleApp1.Models
{
    public class Inventory
    {
        private static List<Pokeball> inventory = new();
        public Trainer? Owner;
        public Pokeball GetItem(int id)
        {
            return inventory[id];
        }
        public bool UseItem(int id)
        {
            bool success = false;
            Pokeball? item = null;
            try
            {
                item = inventory[id];
            }
            catch
            {
                success = false;
                return success;
            }
            if (this.Owner == null)
            {
                return success;
            }
            success = item.Use(this.Owner);
            return success;
        }
        public void ShowInventory()
        {
            var i = 0;
            foreach (Pokeball ball in inventory)
            {
                i ++;
                if (ball.ContainsPokemon)
                {
                    #pragma warning disable CS8602 // Dereference of a possibly null reference.
                    Console.WriteLine($"({i}) Item: Pokeball {{ \n {ball.PokemonInside.ConvertToString()} \n }}");
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
