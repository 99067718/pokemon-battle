using ConsoleApp1.Models;

internal partial class Program
{
    // Create pokeball and add pokemon \\
    
    private static void Main(string[] args)
    {
        Inventory trainer1Inv = new Inventory();
        Inventory trainer2Inv = new Inventory();
        Console.Write("Enter a name for the first trainer: ");
        var name = Console.ReadLine();
        if (name == null || name == "")
        {
            name = "MissingNo";
        }
        Trainer trainer = new Trainer("man", name, trainer1Inv);
        Console.Write("Do you want to name the pokemon? (y/n): ");
        var answer = Console.ReadLine();
        if (answer.ToLower() is "y" or "yes")
        {
            for (var i = 0; i < 6; i++)
            {
                trainer.inventory.AddToInventory(trainer.inventory.CreatePokeball(new Charmender()));
            }
        }
        else
        {
            for (var i = 0; i < 6; i++)
            {
                trainer.inventory.AddToInventory(trainer.inventory.CreatePokeball(new Charmender(false)));
            }
        }
        trainer.inventory.ShowInventory();
        Console.Write("Enter a name for the second trainer: ");
        name = Console.ReadLine();
        if (name == null || name == "")
        {
            name = "MissingNo";
        }
        Trainer trainer2 = new("woman", name, trainer2Inv);
        Console.Write("Do you want to name the pokemon? (y/n): ");
        answer = Console.ReadLine();
        if (answer.ToLower() is "y" or "yes")
        {
            for (var i = 0; i < 6; i++)
            {
                trainer.inventory.AddToInventory(trainer2.inventory.CreatePokeball(new Charmender()));
            }
        }
        else
        {
            for (var i = 0; i < 6; i++)
            {
                trainer.inventory.AddToInventory(trainer2.inventory.CreatePokeball(new Charmender(false)));
            }
        }
        while (true)
        {
#pragma warning disable CS8602 // Dereference of a possibly null reference.
            Console.WriteLine("Write \"exit\" to leave the battle");
            Console.Write("action: ");
            var action = Console.ReadLine().ToString();

            if (action == "exit")
            {
                break;
            }

            // Character.UpdateCharacter(characters.Charmender, name);
#pragma warning restore CS8602 // Dereference of a possibly null reference.

            //Console.WriteLine(characters.Charmender.ToString());
        }
    }
}