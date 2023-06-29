namespace ConsoleApp1.Models
{
    public class Battle
    {
        public static Trainer? StartBattle(Trainer trainer1, Trainer trainer2, Pokeball trainer1pokeball, Pokeball trainer2pokeball)
        {
            if (trainer1 == null || trainer2 == null)
            {
                return null;
            }
            Pokemon? trainer1pokemon = trainer1pokeball.Use(trainer1);
            Pokemon? trainer2pokemon = trainer2pokeball.Use(trainer2);
            if (trainer1pokemon == null || trainer2pokemon == null)
            {
                return null;
            }
            else
            {
                bool? trainerOneHasWon = trainer1pokemon.Versus(trainer2pokemon);
                if (trainerOneHasWon == true)
                {
                    return trainer1;
                }
                else if (trainerOneHasWon == false)
                {
                    return trainer2;
                }
                else
                {
                    return null;
                }
            }
        }
    }
}