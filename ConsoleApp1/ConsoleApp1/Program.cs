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
        // Add pokeballs to trainer 1's inventory \\
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
        // Add pokeballs to trainer 2's inventory \\
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
            Console.WriteLine("Write \"exit\" to leave the battle");
            Console.Write("Do you want to CONTINUE or EXIT: ");
            var action = Console.ReadLine();

            if (action == "exit")
            {
                break;
            }
        }
    }
}