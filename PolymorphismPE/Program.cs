//Nathan McAndrew
//10/24/22
//Utilizing polymorphism to simplify the inheritence PE
using System.Data.Common;

namespace InheritancePE
{ 
    internal class Program
    {
        static void Main(string[] args)
        {
            //creating a list
            List<DnDChar> dndChars = new List<DnDChar>();

            //creating characters
            Warrior goku = new Warrior("Goku", 12, 14, 18, 7, 2, 8);
            Wizard pam = new Wizard("Pam", 7, 8, 6, 15, 18, 19);
            Thief nami = new Thief("Nami", 8, 9, 10, 7, 17, 20);
            
            //adding chars to the list
            dndChars.Add(goku);
            dndChars.Add(pam);
            dndChars.Add(nami);

            //randomly outputs the chars
            Random rng = new Random();
            for (int i = 0; i < 10; i++)
            {
                int randomNum = rng.Next(0, 3);
                DnDChar randChar = dndChars[randomNum];
                Console.WriteLine();
                Console.WriteLine("---Random Character---");
                Console.WriteLine();
                randChar.ToString();
                randChar.SpecialMove();

                //conditionals convert indecies

                if (randChar is Warrior)
                {
                    ((Warrior)randChar).Bathe();
                }

                else if (randChar is Wizard)
                {
                    ((Wizard)randChar).Sorcery();
                }

                else if (randChar is Thief)
                {
                    ((Thief)randChar).PhoneCall();
                }

            }
        }
    }
}