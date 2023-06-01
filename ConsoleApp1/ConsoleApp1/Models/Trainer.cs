namespace ConsoleApp1.Models
{
    public class Trainer
    {
        public string Gender;
        public string Name;
        public Inventory inventory;
        public bool IsPlayer;
        public Pokemon? ReleasedPokemon;
        public bool IsUsingPokemon;

        public string TrainerAction()
        {
            if (this.IsPlayer)
            {
                PlayerInput();
            }
            else
            {
                NpcInput();
            }
            return "";
        }
        private string PlayerInput()
        {
            return "";
        }
        private string NpcInput()
        {
            Inventory inv = this.inventory;
            if (inv == null)
            {
                Console.WriteLine("Your inventory is empty... somehow?");
            }
            else
            {
                var item = inv.GetItem(0);
                item.Use(this);
            }
            return "";
        }
        public Trainer(string gender, string name, Inventory inv) { 
            if(gender.Replace(" ", "") != "" || gender != null)
            {
                Gender = gender;
            }
            else
            {
                Gender = "Attack Helicopter";
            }
            
            if(name.Replace(" ", "") != "" || name != null)
            {
                Name = name;
            }
            else
            {
                Name = "Pieter";
            }
            
            inventory = inv;
        }
    }
}
