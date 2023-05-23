
using System.Net.Http.Json;

namespace ConsoleApp1.Models
{
    public class Pokemon
    {
        private String? PokemonName;
        private String? NickName;
        private String? Type;
        private String[]? Strenght;
        private String[]? Weakness;
        private String? BattleCry;
        public bool IsInPokeball;

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

        //public Character(string name, string chosenName, string strenght, string weakness, string battleCry)
        //{
        //    DefaultName = name;
        //    ChosenName = chosenName;
        //    Strenght = strenght;
        //    Weakness = weakness;
        //    BattleCry = battleCry;
        //    IsInPokeball = false;
        //}
        /*public static Character CreateCharacter()
        {
            Console.Write("Name your pokemon: ");
            #pragma warning disable CS8600 // Converting null literal or possible null value to non-nullable type.
            string name = Console.ReadLine();
            #pragma warning restore CS8600 // Converting null literal or possible null value to non-nullable type.
            Character yourPokemon = new Character("Pikachu", "Pikachu", "Fire", "Water", "Pika Pika");
            if (name != null)
            {
                yourPokemon.ChosenName = name;
                yourPokemon.BattleCry = name;
            }
            return yourPokemon;
        }*/
        public override string ToString()
        {
            return $"DefaultName: {PokemonName} \nChosenName: {NickName} \nStrength: {Strenght} \nWeakness: {Weakness} \nBattleCry: {BattleCry}\n";
        }
        public static void UpdateCharacter(Pokemon character, string name)
        {
            character.NickName = name;
            character.BattleCry = name;
        }
    }
    public class Charmender : Pokemon
    {
        private int BodyHeat;
        public Charmender()
        {
            this.ChangeName();
            this.SetType("fire");
        }
        public override string ToString()
        {
            return $"Name: {this.GetName()} \nType: ";
        }
    }

    
   /* class Characters
    {
        public Character Charmender = new Character(name: "Charmender", chosenName: "Charmender", strenght: "Fire", weakness: "Water", battleCry: "Charmender");
        public Character Pikachu = new Character("Pikachu", "Pikachu", "Fire", "Water", "Pika Pika");
    }*/
}