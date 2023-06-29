
using System.Net.Http.Json;

namespace ConsoleApp1.Models
{
    public abstract class Pokemon
    {
        public string? DefaultName;
        public String? PokemonName;
        private String? NickName;
        private PokemonType? Type;
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
            this.SetType(new Fire());
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

        public void SetType(PokemonType type)
        {
            if (type is Fire or Water or Grass)
            {
                this.Type = type;
            }
            else
            {
                Tools.ErrorMessage($"\"{type}\" is not a valid Type");
            }
        }
        public PokemonType? GetPokemonType()
        {
            return this.Type;
        }
        public bool? Versus(Pokemon pokemon)
        {
            PokemonType? enemyType = pokemon.GetPokemonType();
            if (enemyType != null && this.Type != null)
            {
                bool? result = this.Type.Versus(enemyType);
                return result;
            }
            Console.WriteLine("An error has occurred.");
            return null;
        }
        public string? GetPokemonType_String()
        {
            if (this.Type is Fire)
            {
                return "Fire";
            }
            else if (this.Type is Water)
            {
                return "Water";
            }
            else if (this.Type is Grass)
            {
                return "Grass";
            }
            return "MissingNo";
        }
        public abstract void DoBattleCry();

        public static void UpdateCharacter(Pokemon character, string name)
        {
            character.NickName = name;
        }
        public string ConvertToString()
        {
            return $"Name: {this.GetName()} \n Type: {this.GetPokemonType()}";
        }
    }
    public class Charmender : Pokemon
    {
        private int BodyHeat;
        public Charmender(bool RequiresNameInput = true, string? DefaultName = "Charmender"): base(RequiresNameInput)
        {
            this.SetType(new Fire());
            this.DefaultName = DefaultName;
        }
        public override void DoBattleCry()
        {
            Console.WriteLine("* Makes Charmender sounds *");
        }
    }
    public class Squirtle : Pokemon
    {
        public Squirtle(bool RequiresNameInput = true, string? DefaultName = "Squirtle") : base(RequiresNameInput)
        {
            this.SetType(new Water());
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
            this.SetType(new Grass());
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