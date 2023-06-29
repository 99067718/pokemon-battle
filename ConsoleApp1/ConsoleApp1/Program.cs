﻿using ConsoleApp1.Models;

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
        trainer2Inv.Owner = trainer2;
        Console.Write("Do you want to name the pokemon? (y/n): ");
        answer = Console.ReadLine();
        // Add pokeballs to trainer 2's inventory \\
        if (answer.ToLower() is "y" or "yes")
        {
            for (var i = 0; i < 6; i++)
            {
                trainer2.inventory.AddToInventory(trainer2.inventory.CreatePokeball(new Charmender()));
            }
        }
        else
        {
            for (var i = 0; i < 6; i++)
            {
                trainer2.inventory.AddToInventory(trainer2.inventory.CreatePokeball(new Charmender(false)));
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
                        trainer1Wins++;
                    }
                    else
                    {
                        trainer2Wins++;
                    }
                }
                else
                {
                    ties++;
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
            Console.WriteLine($"{trainer.Name} has won from {trainer2.Name} with a score of {trainer1Wins}");
        }
        else if (trainer2Wins > trainer1Wins)
        {
            Console.WriteLine($"{trainer2.Name} has won from {trainer.Name} with a score of {trainer2Wins}");
        }
        else
        {
            Console.WriteLine($"It's a tie, you both had {trainer1Wins} wins.");
        }
    }
}