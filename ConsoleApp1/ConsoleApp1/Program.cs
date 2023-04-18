
using ConsoleApp1.Models;

internal partial class Program
{
    private static void Main(string[] args)
    {
        Characters characters = new Characters();
        Console.WriteLine(characters.Charmender.ChosenName);
        var e = Console.ReadLine();
        Console.WriteLine("Hello, World!" + e);
    }
}