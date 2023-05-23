using ConsoleApp1.Models;
using System;

internal partial class Program
{
    // Create pokeball and add pokemon \\
    
    private static void Main(string[] args)
    {
        Charmender charmender = new Charmender();

        Inventory trainer1Inv = new Inventory();
        Console.Write("Enter a name for the first trainer: ");
        var name = Console.ReadLine();
        if (name == null || name == "")
        {
            name = "MissingNo";
        }
        Trainer trainer = new Trainer("man", name, trainer1Inv);
        trainer.inventory.AddToInventory(trainer.inventory.CreatePokeball(charmender));

        charmender.SetType("fire");

        while (true)
        {
#pragma warning disable CS8602 // Dereference of a possibly null reference.
            Console.WriteLine("Write \"exit\" to leave the battle");
            Console.Write("name: ");
            name = Console.ReadLine().ToString();

            if (name == "exit")
            {
                break;
            }
            
            Console.WriteLine(charmender.GetName());
            // Character.UpdateCharacter(characters.Charmender, name);
#pragma warning restore CS8602 // Dereference of a possibly null reference.
            for (var i = 0; i <= 5; i++)
            {
                //Console.WriteLine(characters.Charmender.BattleCry);
            }
            //Console.WriteLine(characters.Charmender.ToString());
        }
    }
}