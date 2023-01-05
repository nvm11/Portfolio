//Nathan McAndrew
//10/24/22
//Warrior class DnD Character improved with polymorphism

using System.Security.Cryptography;

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
        /// either reduces or increases the warrior's odor
        /// </summary>
        public void Bathe()
        { 
            Random random = new Random();
            if (random.Next(1, 3) % 2 == 0)
            {
                Console.WriteLine("A shower has been taken!");
                odor = 0;
            }
            else
            {
                Console.WriteLine("The odor grows fierce...");
                odor++;
            }
        }

        /// <summary>
        /// override that includes info specific to the warrior
        /// </summary>
        /// <returns>days since last shower in addition to generic stats</returns>
        public override string ToString()
        {
            return base.ToString() + $" and has not showered in {odor} days";
        }

        /// <summary>
        /// override with output specific to the warrior class
        /// </summary>
        public override void SpecialMove()
        {
            base.SpecialMove();
            Console.Write(" an attempt at finding friends");
            if (odor > 2)
            {
                Console.WriteLine(" but is too stinky!");
            }

            else
            {
                Console.WriteLine(" and meets two fellow warriors!");
            }
        }
    }
}
