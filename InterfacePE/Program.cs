//Nathan McAndrew
//11/7/22
//Shows how interfaces work in C# by seeing if a point is
//contained within a circle
namespace InterfacePE
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //creating points
            Point pointOne = new Point(5, 7);
            Point pointTwo = new Point(10, 10);

            //creating circles
            Circle circleOne = new Circle(10, 10, 3);
            Circle circleTwo = new Circle(0, 0, 5);

            Console.WriteLine("===Printing Info===");
            Console.WriteLine();
            Console.WriteLine("Point 1" + pointOne.ToString());
            Console.WriteLine("Point 2" + pointTwo.ToString());
            Console.WriteLine();
            Console.WriteLine("Cricle 1" + circleOne.ToString());
            Console.WriteLine("Circle 2" + circleTwo.ToString());
            Console.WriteLine();

            Console.WriteLine("===Moving===");
            Console.WriteLine();
            Console.WriteLine("Moving point 2 to (2,2)");
            pointTwo.X = 2;
            pointTwo.Y = 2;
            Console.WriteLine("Moving Circle 2 by (-1, -1)");
            circleTwo.MoveBy(-1, -1);
            Console.WriteLine();

            Console.WriteLine("===Printing Info===");
            Console.WriteLine();
            Console.WriteLine("Point 1: " + pointOne.ToString());
            Console.WriteLine("Point 2: " + pointTwo.ToString());
            Console.WriteLine();
            Console.WriteLine("Cricle 1: " + circleOne.ToString());
            Console.WriteLine("Circle 2: " + circleTwo.ToString());
            Console.WriteLine();

            Console.WriteLine();
            Console.WriteLine("Distance between point one and point two: " + pointOne.DistanceTo(pointTwo));
            Console.WriteLine("Distance between point one and circle one: " + pointOne.DistanceTo(circleOne));
            Console.WriteLine("Distance between point one and circle two: " + pointOne.DistanceTo(circleTwo));
            Console.WriteLine("Distance between point two and circle one: " + pointTwo.DistanceTo(circleOne));
            Console.WriteLine("Distance between point two and circle two: " + pointTwo.DistanceTo(circleTwo));
        }
    }
}