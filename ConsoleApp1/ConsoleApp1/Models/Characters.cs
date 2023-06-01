
using System.Net.Http.Json;

namespace ConsoleApp1.Models
{
    public abstract class Pokemon
    {
        public string? DefaultName;
        public String? PokemonName;
        private String? NickName;
        private String? Type;
        private String[]? Strenght;
        private String[]? Weakness;
        public bool IsInPokeball;

        public Pokemon(bool RequiresNameInput = true, string? DefaultName = "MissingNo")
        {
            this.PokemonName = "Bulbasaur";
            if (RequiresNameInput)
            {
                this.ChangeName();
            }
            else
            {
                this.ChangeName(false, DefaultName);
            }
            this.SetType("fire");
        }
        public void ChangeName(bool RequiresInput = true, string? NickName = null)
        {
            if (RequiresInput)
            {
                Console.Write("Enter a name here: ");
                NickName = Console.ReadLine();
                if (NickName != null)
                {
                    this.NickName = NickName;
                }
                else
                {
                    this.NickName = "MissingNo";
                }
            }
            else
            {
                if (NickName != null)
                {
                    this.NickName = NickName;
                }
                else
                {
                    this.NickName = "MissingNo";
                }
            }
        }

        public string? GetName()
        {
            while(true)
            {
                if (this.NickName != null)
                {
                    return this.NickName;
                }
                else
                {
                    Console.WriteLine("No nick name has been applied to this character yet.");
                    Console.WriteLine("Would you like to change it now?");
                    Console.Write("Yes/No: ");
                    var answer = Console.ReadLine();
                    if (answer != null)
                    {
                        if (answer.ToLower() == "yes")
                        {
                            this.ChangeName();
                        }
                        else
                        {
                            return null;
                        }
                    }
                    else
                    {
                        Console.WriteLine("This answer was not one of the options, null value has been returned.");
                        return null;
                    }
                }
            }
        }

        public void SetType(string type)
        {
            string[] types = { "normal", "fire", "water", "electric", "grass", "ice", "fighting", "poison", "ground", "flying", "psychic", "bug", "rock", "ghost", "dragon", "dark", "steel", "fairy" };
            // 18 types
            int[] strengthmap1 = {1,1,1,1,1,1,1,1,1,1,1,1,0,0,1,1,0,1};
            int[] strengthmap2 = {1,0,0,1,2,2,1,1,1,1,1,2,0,1,0,1,2,1};
            int[] strengthmap3 = {1,2,0,1,0,1,1,1,2,1,1,1,2,1,0,1,1,1};
            int[] strengthmap4 = {1,1,2,0,0,1,1,1,0,2,1,1,1,1,0,1,1,1};
            int[] strengthmap5 = {1,0,2,1,0,1,1,0,2,0,1,0,2,1,0,1,0,1};
            int[] strengthmap6 = { };
            int[] strengthmap7 = { };
            int[] strengthmap8 = { };
            int[] strengthmap9 = { };
            int[] strengthmap10 = { };
            int[] strengthmap11 = { };
            int[] strengthmap12 = { };
            int[] strengthmap13 = { };
            int[] strengthmap14 = { };
            int[] strengthmap15 = { };
            int[] strengthmap16 = { };
            int[] strengthmap17 = { };
            int[] strengthmap18 = { };

            Array[] lists = { strengthmap1, strengthmap2, strengthmap3, strengthmap4, strengthmap5, strengthmap6, strengthmap7, strengthmap8, strengthmap9, strengthmap10, strengthmap11, strengthmap12, strengthmap13, strengthmap14, strengthmap15, strengthmap16, strengthmap17, strengthmap18 };
            if (types.Contains(type)){
                var index = Array.IndexOf(types, type);
                this.Type = type;
            }
            else
            {
                Console.WriteLine("The entered value is not a valid Type");
            }
        }
        public abstract void DoBattleCry();

        public static void UpdateCharacter(Pokemon character, string name)
        {
            character.NickName = name;
        }
        public string ConvertToString()
        {
            return $"Name: {this.GetName()} \n Type: {this.GetType()}";
        }
    }
    public class Charmender : Pokemon
    {
        private int BodyHeat;
        public Charmender(bool RequiresNameInput = true, string? DefaultName = "Charmender"): base(RequiresNameInput)
        {
            this.DefaultName = DefaultName;
        }
        public override void DoBattleCry()
        {
            Console.WriteLine("* Makes Charmender sounds *");
        }
    }
    public class Squirtle  : Pokemon
    {
        public Squirtle(bool RequiresNameInput = true, string? DefaultName = "Squirtle") : base(RequiresNameInput)
        {
            this.DefaultName = DefaultName;
        }
        public override void DoBattleCry()
        {
            Console.WriteLine("* Makes Squirtle sounds *");
        }
    }
    public class Bulbasaur : Pokemon
    {
        public Bulbasaur(bool RequiresNameInput = true, string? DefaultName = "Bulbasaur"): base(RequiresNameInput)
        {
            this.DefaultName = DefaultName;
        }
        public override void DoBattleCry()
        {
            Console.WriteLine("* Makes Bulbasaur sounds *");
        }
    }


    /* class Characters
     {
         public Character Charmender = new Character(name: "Charmender", chosenName: "Charmender", strenght: "Fire", weakness: "Water", battleCry: "Charmender");
         public Character Pikachu = new Character("Pikachu", "Pikachu", "Fire", "Water", "Pika Pika");
     }*/
}