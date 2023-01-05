//Nathan McAndrew
//10/24/22
//Creates thief class DnD character improved with polymorphism

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
        /// increases or decreases likelihood of stealing
        /// </summary>
        public void PhoneCall()
        {
            if (phoneRings > 8)
            {
                Console.WriteLine("The phone plan has been changed!");
                phoneRings = 0;
            }
            else
            {
                phoneRings += 2;
                Console.WriteLine("Spam callers hungrily stare at the thief!");
            }
        }
        
        /// <summary>
        /// customizes method for thief class
        /// </summary>
        /// <returns>the number of phone calls in addition to
        /// basic stats</returns>
        public override string ToString()
        {
            string printInfo;
            if (phoneRings > 3)
            {
                printInfo = "gets {phoneRings} untimely calls a day." +
                    $" They needs to change their cell provider...";
            }

            else
            {
               printInfo = $"{name} is happy with their current phone plan.";
            }
            return base.ToString() + printInfo;
        }

        /// <summary>
        /// /outputs the results of the thief specific action
        /// </summary>
        public override void SpecialMove()
        {
            base.SpecialMove();
            Console.Write(" an attempt at stealing,");
            if (phoneRings > 3)
            {
                Console.WriteLine(" but is too busy answering calls!");
            }
            else
            {
                Console.WriteLine(" they change their cell provider and steal!");
            }
        }
    }
}
