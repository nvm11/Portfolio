//Nathan McAndrew
//10/19/22
//Showcases INheritance and through DnD
//characters' unique resources
namespace InheritancePE
{ 
    internal class Program
    {
        static void Main(string[] args)
        {
            Warrior goku = new Warrior("Goku", 12, 14, 18, 7, 2, 8);
            Wizard pam = new Wizard("Pam", 7, 8, 6, 15, 18, 19);
            Thief nami = new Thief("Nami", 8, 9, 10, 7, 17, 20);

            Console.WriteLine("Character Stats:");

            goku.PrintWarrior();
            pam.PrintWizard();
            nami.PrintThief();

            Console.WriteLine();
            Console.WriteLine("Special Moves:");

            goku.SpecialMove();
            pam.SpecialMove();
            nami.SpecialMove();

            goku.Odor = 6;
            pam.HotPocket = 68;
            nami.PhoneRings = 4;

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Character Stats:");

            goku.PrintWarrior();
            pam.PrintWizard();
            nami.PrintThief();

        }
    }
}