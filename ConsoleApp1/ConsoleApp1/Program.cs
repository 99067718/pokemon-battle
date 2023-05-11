using ConsoleApp1.Models;
using System;

internal partial class Program
{
    // Create pokeball and add pokemon \\
    
    private static void Main(string[] args)
    {
        Charmender person = new Charmender();
        person.SetType("fire");
        //Inventory.CreatePokeball(Character.CreateCharacter());
        Inventory.ShowInventory();
        /*Characters characters = new Characters();
        Inventory.CreatePokeball(characters.Pikachu);
        Inventory.CreatePokeball(characters.Charmender);
        Console.WriteLine(characters.Charmender.ToString());
        Console.WriteLine(characters.Pikachu.ToString());
        */
        var name = "unknown";

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
            //Character.UpdateCharacter(characters.Charmender, name);
#pragma warning restore CS8602 // Dereference of a possibly null reference.
            for (var i = 0; i <= 5; i++)
            {
                //Console.WriteLine(characters.Charmender.BattleCry);
            }
            //Console.WriteLine(characters.Charmender.ToString());
        }
    }
}