//Nathan McAndrew
//10/24/22
//wizard class DnD char improved with polymorphism

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
        /// increases or decreases the chance of a spell
        /// </summary>
        public void Sorcery()
        { 
            Random random = new Random();
            hotPocket = random.Next(0, 100);
            Console.WriteLine("The likelihood of hotpockets has changed!");
        }

        /// <summary>
        /// overrides ToString with infor specific to wizard
        /// </summary>
        /// <returns>unique stat for the wizard in addition to
        /// generic stats</returns>
        public override string ToString()
        {
            return base.ToString() + $"and creates Hot Pockets {hotPocket}% of the time";
        }

        /// <summary>
        /// outputs results of the wizard's unique action
        /// </summary>
        public override void SpecialMove()
        {
            base.SpecialMove();
            Console.Write(" a spell,");
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
