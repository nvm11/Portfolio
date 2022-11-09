//Nathan McAndrew
//10/27/22
//Deata for a gambling arch-type character
//As the rounds progress, the odds of a more damaging attack increases as well. 
//Gambler has a 1 in 7 chance of getting lucky and avoiding an attack. 
//Gamblers can also hit the "jackpot" if their roll equals a random value
//which results in doubled damage
using System.Security.Cryptography;

namespace NMHomework5
{
    internal class Gambler : CommonCharacter
    {
        //Fields
        private int luck;
        private int[] luckValues;
        Random rng;
        private int jackpot;
        private int roll;
        //Constructor
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="luck">index in luck values. as luck increases, minimum damage increases as well </param>
        /// <param name="name">name of character</param>
        /// <param name="maxAttack">maximum ammount of damage that can be dealt</param>
        /// <param name="startingHealth"></param>
        public Gambler(string name, int maxAttack, int startingHealth)
            :base (name, maxAttack, startingHealth)
        {
            rng = new Random();
            this.luck = 0;
            this.luckValues = new int[] {0, maxAttack / 6, maxAttack / 5, maxAttack / 4, maxAttack / 3, maxAttack / 2, maxAttack - 1};
            this.jackpot = rng.Next(0, MaxAttack + 1);
        }

        /// <summary>
        /// gets amount of luck character currently has
        /// </summary>
        public int Luck {get {return luck;}}

        /// <summary>
        /// simulates the gambler attacking. He has a 1 in three chance
        /// of decreasing the minimum roll value
        /// </summary>
        /// <returns>the amount of damage 
        /// to be dealt to the opponent</returns>
        public override int Attack()
        {
            if (rng.Next(0, 2) % 2 == 1)
            {
                if (luck < luckValues.Length - 1)

                {
                    luck += 1;
                }
            }
            roll = rng.Next(luckValues[luck], MaxAttack + 1);
            
            if (roll == jackpot)
            {
                return MaxAttack * 2;
            }
            
            return roll;
        }

        /// <summary>
        /// in exchange of gambler's potentially good offense,
        /// there is a 1 in 7 they take no damage, but this decreases
        /// their luck
        /// </summary>
        /// <param name="amount">amount of damage to be taken</param>
        public override void TakeDamage(int amount)
        {
            if (rng.Next(0, 7) == luck)
            {
                Console.WriteLine($"{Name} avoided the attack!");
                if (luck > 0)
                {
                    luck--;
                }
            }

            else
            {
                base.TakeDamage(amount);
            }
        }

        /// <summary>
        /// used to determine if the gambler is willing to flee. If their luck has reached level 4, 
        /// </summary>
        /// <returns>true if ready, false otherwise</returns>
        public override bool ReadyToFlee()
        {
            if (luck < 4 && CurrentHealth < 25)
            { 
                return true;
            }

            return false;
        }

        /// <summary>
        /// overrides To string to include info specific to the gambler
        /// </summary>
        /// <returns>data specific to the gambler in addition to generic info</returns>
        public override string ToString()
        {
            return base.ToString() + $" as well as {luck} luck level(s).";
        }
    }
}
