//Nathan McAndrew
//10/27/22
//Child class for a solider character
//Solider does very consistent damage. They attack with a grenade every fourth turn.
//Soliders will never run from a fight. Additionally, soliders have 5 plates of armor
//so the first 5 attacks aimed at them will be reduced.
namespace NMHomework5
{
    internal class Solider : CommonCharacter
    {
        //Fields
        private int attackMethod;
        private int armorCount;

        //Constructor

        /// <summary>
        /// creates a solider object snd assigns a value of zero
        /// to their unique attribute
        /// </summary>
        /// <param name="name">name of solider</param>
        /// <param name="maxAttack">maximim damage for one attack</param>
        /// <param name="startingHealth">starting health</param>
        public Solider(string name, int maxAttack, int startingHealth)
            : base (name, maxAttack, startingHealth)
        {
            attackMethod = 0;
            armorCount = 5;
        }

        //Methods

        /// <summary>
        /// simulates solider attaking. does 1/4 of max damage
        /// 3 out of four times, and maxt damage the other.
        /// </summary>
        /// <returns>the amount of damage to be reduced from the target</returns>
        public override int Attack()
        {
            if (attackMethod < 3)
            { 
                attackMethod++;
                return MaxAttack / 4;
            }
            
            attackMethod = 0;
            return MaxAttack;
        }

        /// <summary>
        /// Unique method for the solider taking damage
        /// </summary>
        /// <param name="amount">amount of damage recieved</param>
        public override void TakeDamage(int amount)
        {
            //applies reduces attack and decreases armor count
            if (armorCount > 0)
            {
                Console.WriteLine($"{Name}'s armor reduced the damage!");
                base.TakeDamage((amount / 10)*8);
                armorCount--;
            }
            //used when no armor is left
            else
            { 
                base.TakeDamage(amount);
            }
        }

        /// <summary>
        /// Soliders never flee the battle
        /// </summary>
        /// <returns>false always</returns>
        public override bool ReadyToFlee()
        {
            return false;
        }

        /// <summary>
        /// returns generic data as well
        /// as how many turns away from grenade
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return base.ToString() + $" and is {4 - attackMethod} turns away from a grenade.";
        }
    }
}
