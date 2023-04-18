
namespace ConsoleApp1.Models
{
    class Character
    {
        public string DefaultName { get; set; }
        public string ChosenName { get; set; }
        public string Strenght { get; set; }
        public string Weakness { get; set; }
        public string BattleCry { get; set; }

        public Character(string name, string chosenName, string strenght, string weakness, string battleCry)
        {
            DefaultName = name;
            ChosenName = chosenName;
            Strenght = strenght;
            Weakness = weakness;
            BattleCry = battleCry;
        }

        public override string ToString()
        {
            return $"DefaultName: {DefaultName}, ChosenName: {ChosenName}, Strength: {Strenght}, Weakness: {Weakness}, BattleCry: {BattleCry}";
        }
    }
    class Characters
    {
        public Character Charmender = new Character(name: "Charmender", chosenName: "Charmender", strenght: "Fire", weakness: "Water", battleCry: "Charmender");
        // public Character Pikachu = new Character("Pikachu", "Pikachu", "Fire", "Water", "Pika Pika");
    }
}