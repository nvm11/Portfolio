//Nathan McAndrew
//10/19/22
//wizard class DnD char

namespace InheritancePE
{
    internal class Wizard : DnDChar
    {
        private int hotPocket;

        public Wizard(string name,
                       int strength,
                       int dexterity,
                       int constitution,
                       int wisdom,
                       int intelligence,
                       int charisma)

                       : base(name,
                       "Wizard",
                       strength,
                       dexterity,
                       constitution,
                       wisdom,
                       intelligence,
                       charisma)
        {
            hotPocket = 25;
        }

        /// <summary>
        /// gets hot pocket percentage or sets it
        /// </summary>
        public int HotPocket
        {
            get { return hotPocket; }
            set { hotPocket = value; }
        }

        /// <summary>
        /// Outputs wizard-specific stats
        /// </summary>
        public void PrintWizard()
        {
            Print();
            Console.WriteLine();
            Console.WriteLine($"{name}, a {CharClass}, creates Hot Pockets" +
                $" {hotPocket}% of the time.");
        }

        /// <summary>
        /// outputs result of attack
        /// </summary>
        public void SpecialMove()
        {
            Console.WriteLine();
            Console.Write($"{name} attempts to cast a spell,");
            Random rng = new Random();
            if (rng.Next(0, 101) < HotPocket)
            {
                Console.WriteLine(" but plops out a HotPocket(tm)!!!");
            }

            else
            {
                Console.WriteLine(" and shoots a SUPER DUPER AWESOME BEAM (tm)!!!");
            }
        }
    }
}
