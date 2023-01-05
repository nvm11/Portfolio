//Nathan McAndrew
//10/19/22
//Creates thief class DnD character

namespace InheritancePE
{
    internal class Thief : DnDChar
    {
        private int phoneRings;

        public Thief(string name,
                       int strength,
                       int dexterity,
                       int constitution,
                       int wisdom,
                       int intelligence,
                       int charisma)

                       : base(name,
                       "Thief",
                       strength,
                       dexterity,
                       constitution,
                       wisdom,
                       intelligence,
                       charisma)
        {
            phoneRings = 0;
        }

        /// <summary>
        /// gets number of rings or sets them equal to a value
        /// </summary>
        public int PhoneRings
        {
            get { return phoneRings; }
            set { phoneRings = value; }
        }

        /// <summary>
        /// displays stats unique to the thief
        /// </summary>
        public void PrintThief()
        {
            
            Print();
            Console.WriteLine();
            if (phoneRings > 3)
            {
                Console.WriteLine($"{name}, a {CharClass}, gets {phoneRings} untimely calls a day." +
                    $" They needs to change their cell provider...");
            }

            else
            {
                Console.WriteLine($"{name} is happy with their current phone plan.");
            }
        }

        /// <summary>
        /// Randomly generates the number of phone calls during the battle 
        /// </summary>
        /// <returns>number of calls</returns>
        public void SpecialMove()
        {
            Console.WriteLine();
            Console.Write($"{name} attempts to steal,");
            if (phoneRings > 3)
            {
                Console.Write(" but is too busy answering calls!");
            }
            else 
            {
                Console.Write(" they change their cell provider and steal!");
            }
        }


    }
}
