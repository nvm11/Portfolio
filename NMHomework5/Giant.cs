//Nathan McAndrew
//10/31/22
//Child class for a "giant" character tyoe
//Giants are very strong, but move slowly
//this causes the giant to have a chance at missing attacks
//but they take less damage for the first ten attacks aimed at them

namespace NMHomework5
{
    internal class Giant : CommonCharacter
    {
        //Fields
        private Random rng;
        private int attackCount;
        //Constructor

        /// <summary>
        /// creates a giant character (child of CommonCharacter)
        /// </summary>
        /// <param name="name">name of giant</param>
        /// <param name="maxAttack">maximum attack to be dealt</param>
        /// <param name="startingHealth">starting health of the character</param>
        public Giant(string name, int maxAttack, int startingHealth)
        : base (name, maxAttack, startingHealth)
        { 
            rng = new Random ();
            attackCount = 0;
        }

        /// <summary>
        /// determines how much damage the giant deals
        /// </summary>
        /// <returns>numeric value to be subtracted from 
        /// another object's health</returns>
        public override int Attack()
        {
            if (rng.Next(0, 3) == 0)
            {
                return 0;
            }

            else 
            {
                return MaxAttack;
            }
        }

        /// <summary>
        /// reduces the health of the giant character, accounting for its
        /// defensive mechanic
        /// </summary>
        /// <param name="amount">amount of damage to be recieved</param>
        public override void TakeDamage(int amount)
        {
            if (attackCount < 10)
            {
                Console.WriteLine($"{Name}'s giant body reduced the damage!");
                base.TakeDamage(amount / 3);
                attackCount++;
            }

            else
            { 
                base.TakeDamage(amount);
            }
        }

        /// <summary>
        /// adds giant-specific information to ToString
        /// </summary>
        /// <returns>generic and giant related stats</returns>
        public override string ToString()
        {
            return base.ToString() + $" and has reduced damage {attackCount} times.";
        }
    }
}
