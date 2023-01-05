//Nathan McAndrew
//10/24/22
//Generates generic DND stats and methods improved with polymorphism
namespace InheritancePE
{
    internal class DnDChar
    {
        protected string name;
        private string charClass;
        protected int strength;
        protected int dexterity;
        protected int constitution;
        protected int wisdom;
        protected int intelligence;
        protected int charisma;

        public DnDChar(
            string name,
            string charClass,
            int strength,
            int dexterity,
            int constitution,
            int wisdom,
            int intelligence,
            int charisma)
        { 
            this.name = name;
            this.charClass = charClass;
            this.strength = strength;
            this.dexterity = dexterity;
            this.constitution = constitution;
            this.wisdom = wisdom;
            this.intelligence = intelligence;
            this.charisma = charisma;

        }

        /// <summary>
        /// gets character name
        /// </summary>
        public string Name { get { return name; } }
        /// <summary>
        /// gets or sets character class
        /// </summary>
        public string CharClass
        {
            get { return charClass; }
            set { charClass = value; }
        }
        /// <summary>
        /// gets or sets character strength
        /// </summary>
        public int Strength
        {
            get { return strength; }
            set { strength = value; }
        }
       /// <summary>
       /// gets or sets character strength
       /// </summary>
        public int Dexterity
        {
            get { return dexterity; }
            set { dexterity = value; }
        }
        /// <summary>
        /// gets or sets character constitution
        /// </summary>
        public int Constitution
        {
            get { return constitution; }
            set { constitution = value; }
        }
        /// <summary>
        /// gets or sets character wisdom
        /// </summary>
        public int Wisdom
        {
            get { return wisdom; }
            set { wisdom = value; }
        }
        /// <summary>
        /// gets or sets character intelligence
        /// </summary>
        public int Intelligence
        {
            get { return intelligence; }
            set { intelligence = value; }
        }
        /// <summary>
        /// gets or sets character charisma
        /// </summary>
        public int Charisma
        {
            get { return charisma; }
            set { charisma = value; }
        }


       /// <summary>
       /// overrides ToString to provide generic stats when called
       /// </summary>
       /// <returns>generic DnD character stats</returns>
        public override string ToString()
        {
            return $"{name} has {strength} strength, {dexterity} dexterity, and {intelligence} intelligence";
        }

        /// <summary>
        /// method that outputs a message
        /// informing users of a charcter performing a move
        /// </summary>
        public virtual void SpecialMove()
        {
            Console.Write($"{name} performs...");
        }
    }
}
