//Nathan McAndrew
//10/27/22
//Simulates a "battle royale" between 4 characters
namespace NMHomework5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ading characters to the list
            List<CommonCharacter> characters = new List<CommonCharacter>();
            characters.Add(new Giant("Big Joe", 150, 1000));
            characters.Add(new Solider("Captain Trapp", 100, 800));
            characters.Add(new Solider("Levi", 120, 800));
            characters.Add(new Gambler("Michael", 200, 750));
            
            int roundCount = 0;
            int target;
            int damage;

            Console.WriteLine("Contestants ---");
            Console.WriteLine();

            //displays character names and stats
            for (int k = 0; k < characters.Count; k++)
            {
                Console.WriteLine(characters[k].ToString());
            }
            
            while (characters.Count > 1)
            {
                roundCount++;
                Console.WriteLine();
                Console.WriteLine($"Round {roundCount} ---");
                Console.WriteLine();
                
                //allows every character to attack
                for (int i = 0; i < characters.Count; i++)
                {
                    target = GetTarget(i, characters);
                    damage = characters[i].Attack();
                    Console.WriteLine($"{characters[i].Name} attacks {characters[target].Name} for {damage} damage.");
                    characters[target].TakeDamage(damage);
                }

                //checks for deaths/fleeing
                for (int j = 0; j < characters.Count; j++)
                {
                    if (characters[j].CurrentHealth < 0)
                    {
                        Console.WriteLine();
                        Console.WriteLine($"{characters[j].Name} has perished...");
                        characters.RemoveAt(j);
                    }

                    else if (characters[j].ReadyToFlee())
                    {
                        Console.WriteLine();
                        Console.WriteLine($"{characters[j].Name} has fled!");
                        characters.RemoveAt(j);
                    }
                }
                Console.WriteLine();
                Console.WriteLine("<Press any key to continue>");
                Console.ReadKey();
            }

            Console.WriteLine();
            //displays winner
            if (characters.Count > 0)
            {
                Console.WriteLine($"{characters[0].Name} is the winner!");
            }

            //displays in the event of a tie
            else 
            {
                Console.WriteLine("There are no winners!");
            }

        }

        /// <summary>
        /// rerolls random number generator to obtain 
        /// a valid target for the attack
        /// </summary>
        /// <param name="attacker">index of the character
        /// attacking</param>
        /// <param name="characters">list of characters</param>
        /// <returns>index of the target</returns>
        public static int GetTarget(int attacker, List<CommonCharacter> characters)
        { 
            Random rng = new Random();
            int target = rng.Next(0, characters.Count);
            while (target == attacker)
            {
                target = rng.Next(0, characters.Count);
            }
            return target;
        }
    }
}