//Nathan McAndrew
//10/19/22
//Warrior class DnD Character

namespace InheritancePE
{
    internal class Warrior : DnDChar
    {
        private int odor;

        public Warrior(string name,
                       int strength,
                       int dexterity,
                       int constitution,
                       int wisdom,
                       int intelligence,
                       int charisma)

                       : base(name,
                       "Warrior",
                       strength,
                       dexterity,
                       constitution,
                       wisdom,
                       intelligence,
                       charisma)
        {
            odor = 0;
        }
        
        /// <summary>
        /// gets odor value or sets it
        /// </summary>
        public int Odor
        { 
            get { return odor; }
            set { odor = value; }
        }

        /// <summary>
        /// outputs warrior-specific stats
        /// </summary>
        public void PrintWarrior()
        {
            Print();
            Console.WriteLine();
            if (odor > 0)
            {
                Console.WriteLine($"{name}, a {CharClass}, has not showered in {odor} day(s).");
            }
            else
            {
                Console.WriteLine($"{name}, a {CharClass}, is squeaky clean!");
            }
        }

        /// <summary>
        /// Outputs the result of the warrior's special move
        /// </summary>
        public void SpecialMove()
        {
            Console.WriteLine();
            Console.Write($"{name} attempts to find friends,");
            if (odor > 2)
            {
                Console.Write(" but is too stinky!");
            }

            else 
            {
                Console.Write(" and meets two fellow warriors!");
            }
        }
    }
}
