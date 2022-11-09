//Nathan McAndrew
//10/27/22
//Base stats and methods that all
//child classes must contain

using System.Net.Mail;

namespace NMHomework5
{
    internal abstract class CommonCharacter
    {
        //Fields
        
        private string name;
        private int maxAttack;
        private int startingHealth;
        private int currentHealth;

        //Constructor

        /// <summary>
        /// sets up basic character stats
        /// </summary>
        /// <param name="name">character name</param>
        /// <param name="maxAttack">maximum amount of damage they can do</param>
        /// <param name="startingHealth">starting health (doesn't change)</param>
        public CommonCharacter(string name, int maxAttack, int startingHealth)
        { 
            this.name = name;
            this.maxAttack = maxAttack;
            this.startingHealth = startingHealth;
            this.currentHealth = startingHealth;
        }

        //Properties
        
        /// <summary>
        /// gets name
        /// </summary>
        public string Name { get { return name; } }

        /// <summary>
        /// gets max attack value or sets value
        /// </summary>
        public int MaxAttack
        { 
            get { return maxAttack; }
            set { maxAttack = value; }
        }

        /// <summary>
        /// gets starting health
        /// </summary>
        public int StartingHealth { get { return startingHealth; } }

        /// <summary>
        /// gets current health of a character or changes it
        /// </summary>
        public int CurrentHealth
        { 
            get { return currentHealth; } 
            set { currentHealth = value; }
        }

        //Methods

        /// <summary>
        /// Attack method to be overwritten by child class
        /// </summary>
        /// <returns>value of target's health after attack</returns>
        public abstract int Attack();

        /// <summary>
        /// applies damage to specified character
        /// </summary>
        /// <param name="amount">amount of damage dealt</param>
        public virtual void TakeDamage(int amount)
        {
            CurrentHealth -= amount;
        }

        /// <summary>
        /// checks if a character's flee condition has been met
        /// </summary>
        /// <returns>true if it has, false if not</returns>
        public virtual bool ReadyToFlee()
        {
            if (CurrentHealth <= 10)
            { 
                return true;
            }
            return false;
        }

        /// <summary>
        /// checks if a character's health is 0 or less
        /// </summary>
        /// <returns>true if it is and false if it isnt</returns>
        public bool IsDead()
        {
            if (currentHealth <= 0)
            { 
                return true;
            }
            return false;
        }

        /// <summary>
        /// returns generic stats in a string
        /// </summary>
        /// <returns>sentence containing generic character stats</returns>
        public override string ToString()
        {
            return $"{Name} has a max attack of {MaxAttack} and {CurrentHealth} health remaining";
        }
    }
}
