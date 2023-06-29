using System;

namespace ConsoleApp1.Models
{
    public class Tools
    {
        public static void ErrorMessage(string message)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"X Error: {message}");
            Console.ForegroundColor = ConsoleColor.White;
        }

        public static void WarningMessage(string message)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"! Warning: {message}");
            Console.ForegroundColor = ConsoleColor.White;
        }

        public static void HintMessage(string message)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"? Hint: {message}");
            Console.ForegroundColor = ConsoleColor.White;
        }
        public static void SuccessMessage(string message)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Succes: {message} \\ ('o') /");
            Console.ForegroundColor = ConsoleColor.White;
        }
        public static void RainbowMessage(string message)
        {
            List<ConsoleColor> colors = new();
            colors.Add( ConsoleColor.Red );
            colors.Add( ConsoleColor.Cyan );
            colors.Add( ConsoleColor.White );   
            colors.Add( ConsoleColor.Yellow );
            colors.Add( ConsoleColor.DarkMagenta );
            colors.Add( ConsoleColor.Green );
            colors.Add( ConsoleColor.DarkBlue );
            message = $"RainbowMessage: {message}";
            for (int i = 0; i < message.Length; i++)
            {
                Random random = new();
                int index = random.Next(colors.Count);
                Console.ForegroundColor = colors[index];
                Console.Write(message[i]);
            }
            Console.WriteLine("");
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
