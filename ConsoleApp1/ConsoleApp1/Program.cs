
using ConsoleApp1.Models;

internal partial class Program
{
    private static void UpdateCharacter(Character character, string name)
    {
        character.ChosenName = name;
        character.BattleCry = name;
    }
    private static void Main(string[] args)
    {
        Characters characters = new Characters();
        Console.WriteLine(characters.Charmender.ToString());
        Console.WriteLine(characters.Pikachu.ToString());
        var name = "unknown";
        while (true)
        {
#pragma warning disable CS8602 // Dereference of a possibly null reference.
            name = Console.ReadLine().ToString();
            UpdateCharacter(characters.Charmender, name);
#pragma warning restore CS8602 // Dereference of a possibly null reference.
            for (var i = 0; i <= 5; i++)
            {
                Console.WriteLine(characters.Charmender.BattleCry);
            }
            Console.WriteLine(characters.Charmender.ToString());
        }
        var e = Console.ReadLine();
        Console.WriteLine("Hello, World!" + e);
    }
}