using ConsoleApp1.Models;

internal partial class Program
{
    // Create pokeball and add pokemon \\
    
    private static void Main(string[] args)
    {
        Tools.ErrorMessage("oh no, error");
        Tools.WarningMessage("you haven't selected a type yet, this can cause errors!");
        Tools.HintMessage("when you have low hp, you can always heal!");
        Tools.SuccessMessage("Game loaded successfully!");
        Tools.RainbowMessage("whoa it's a randomized rainbow!");

        Inventory trainer1Inv = new();
        Inventory trainer2Inv = new();
        Console.Write("Enter a name for the first trainer: ");
        var name = Console.ReadLine();
        if (name == null || name == "")
        {
            name = "MissingNo";
        }
        Trainer trainer = new Trainer("man", name, trainer1Inv);
        trainer1Inv.Owner = trainer;
        Console.Write("Do you want to name the pokemon? (y/n): ");
        string? answer = Console.ReadLine();

        // Add pokeballs to trainer 1's inventory \\
        Random random = new Random();
        if (answer.ToLower() is "y" or "yes")
        {
            for (var i = 0; i < 6; i++)
            {
                int chosennum = random.Next(2);
                if (chosennum == 0)
                {
                    trainer.inventory.AddToInventory(trainer.inventory.CreatePokeball(new Charmender()));
                }
                else if (chosennum == 1)
                {
                    trainer.inventory.AddToInventory(trainer.inventory.CreatePokeball(new Squirtle()));
                }
                else
                {
                    trainer.inventory.AddToInventory(trainer.inventory.CreatePokeball(new Bulbasaur()));
                }
                
            }
        }
        else
        {
            for (var i = 0; i < 6; i++)
            {
                int chosennum = random.Next(2);
                if (chosennum == 0)
                {
                    trainer.inventory.AddToInventory(trainer.inventory.CreatePokeball(new Charmender(false)));
                }
                else if (chosennum == 1)
                {
                    trainer.inventory.AddToInventory(trainer.inventory.CreatePokeball(new Squirtle(false)));
                }
                else
                {
                    trainer.inventory.AddToInventory(trainer.inventory.CreatePokeball(new Bulbasaur(false)));
                }
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
        trainer2Inv.Owner = trainer2;
        Console.Write("Do you want to name the pokemon? (y/n): ");
        answer = Console.ReadLine();
        // Add pokeballs to trainer 2's inventory \\
        if (answer.ToLower() is "y" or "yes")
        {
            for (var i = 0; i < 6; i++)
            {
                int chosennum = random.Next(2);
                if (chosennum == 0)
                {
                    trainer2.inventory.AddToInventory(trainer2.inventory.CreatePokeball(new Charmender()));
                }
                else if (chosennum == 1)
                {
                    trainer2.inventory.AddToInventory(trainer2.inventory.CreatePokeball(new Squirtle()));
                }
                else
                {
                    trainer2.inventory.AddToInventory(trainer2.inventory.CreatePokeball(new Bulbasaur()));
                }
            }
        }
        else
        {
            for (var i = 0; i < 6; i++)
            {
                int chosennum = random.Next(2);
                if (chosennum == 0)
                {
                    trainer2.inventory.AddToInventory(trainer2.inventory.CreatePokeball(new Charmender(false)));
                }
                else if (chosennum == 1)
                {
                    trainer2.inventory.AddToInventory(trainer2.inventory.CreatePokeball(new Squirtle(false)));
                }
                else
                {
                    trainer2.inventory.AddToInventory(trainer2.inventory.CreatePokeball(new Bulbasaur(false)));
                }
            }
        }
        int trainer1Wins = 0;
        int trainer2Wins = 0;
        int ties = 0;
        while (true)
        {
            try
            {
                var pokemontrainer1 = trainer.inventory.GetItem(trainer2Wins + ties);
                var pokemontrainer2 = trainer2.inventory.GetItem(trainer1Wins + ties);
                Trainer? winner = Battle.StartBattle(trainer, trainer2, pokemontrainer1, pokemontrainer2);
                if (winner != null)
                {
                    if (winner == trainer)
                    {
                        trainer1Wins += 1;
                    }
                    else
                    {
                        trainer2Wins += 1;
                    }
                }
                else
                {
                    ties += 1;
                }
            }
            catch
            {
                break;
            }
        }
        Console.WriteLine("Final Results:");
        if (trainer1Wins > trainer2Wins)
        {
            Tools.SuccessMessage($"{trainer.Name} has won from {trainer2.Name} with a score of {trainer1Wins}");
        }
        else if (trainer2Wins > trainer1Wins)
        {
            Tools.SuccessMessage($"{trainer2.Name} has won from {trainer.Name} with a score of {trainer2Wins}");
        }
        else
        {
            Tools.WarningMessage($"It's a tie, you both had {trainer1Wins} wins.");
        }
    }
}