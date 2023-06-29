using System;
namespace ConsoleApp1.Models
{
    public abstract class PokemonType
    {
        public abstract bool? Versus(PokemonType EnemyType);
    }
    public class Fire : PokemonType
    {
        public override bool? Versus(PokemonType EnemyType)
        {
            if (EnemyType is Water)
            {
                return false;
            }
            else if (EnemyType is Grass) {
                return true;
            }
            else if (EnemyType is Fire)
            {
                return null;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("ERROR: Enemy does not have a valid type, attack has been canceled.");
                Console.ForegroundColor = ConsoleColor.White;
                return false;
            }
        }
    }
    public class Grass : PokemonType
    {
        public override bool? Versus(PokemonType EnemyType)
        {
            if (EnemyType is Water)
            {
                return true;
            }
            else if (EnemyType is Grass)
            {
                return null;
            }
            else if (EnemyType is Fire)
            {
                return false;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("ERROR: Enemy does not have a valid type, attack has been canceled.");
                Console.ForegroundColor = ConsoleColor.White;
                return false;
            }
        }
    }
    public class Water : PokemonType
    {
        public override bool? Versus(PokemonType EnemyType)
        {
            if (EnemyType is Water)
            {
                return null;
            }
            else if (EnemyType is Grass)
            {
                return false;
            }
            else if (EnemyType is Fire)
            {
                return true;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("ERROR: Enemy does not have a valid type, attack has been canceled.");
                Console.ForegroundColor = ConsoleColor.White;
                return false;
            }
        }
    }
}
