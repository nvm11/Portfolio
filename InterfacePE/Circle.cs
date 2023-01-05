//Nathan McAndrew
//11/7/22
//class with the properties of a circle
namespace InterfacePE
{
    internal class Circle : IPosition, IArea
    {
        private double x;
        private double y;
        private double radius;

        /// <summary>
        /// creates a circe
        /// </summary>
        /// <param name="x">x coordinate of circle center</param>
        /// <param name="y">y coordinate of circle center</param>
        /// <param name="radius">radius of circle</param>
        public Circle(double x, double y, double radius)
        {
            this.x = x;
            this.y = y;
            this.radius = radius;
        }

        /// <summary>
        /// gets or sets the x coordinate
        /// </summary>
        public double X
        {
            get { return x; }
            set { x = value; }
        }

        /// <summary>
        /// gets or sets the y coordinate
        /// </summary>
        public double Y
        {
            get { return y; }
            set { y = value; }
        }

        /// <summary>
        /// gets or sets the radius
        /// </summary>
        public double Radius
        {
            get{ return radius; } 
            set { radius = value; }
        }

        /// <summary>
        /// returns the area of the circle
        /// </summary>
        public double Area
        { get { return Math.Round(Math.PI * Math.Pow(Radius, 2), 2); } }

        /// <summary>
        /// returns the perimeter of the circle
        /// </summary>
        public double Perimeter
        { get { return Math.Round(Math.PI * Radius * 2, 2); } }

        /// <summary>
        /// obtains the distance between the object's
        /// coordinates adn those of another's
        /// </summary>
        /// <param name="position">other coodrinate</param>
        /// <returns>distance between the points</returns>
        public double DistanceTo(IPosition position)
        {
            double xDistance = Math.Pow((X - position.X), 2);
            double yDistance = Math.Pow((Y - position.Y), 2);
            return Math.Round(Math.Sqrt(xDistance + yDistance), 2);
        }

        /// <summary>
        /// changes the x and y coordinates to
        /// the specified values
        /// </summary>
        /// <param name="x">new x value</param>
        /// <param name="y">new y value</param>
        public void MoveTo(double x, double y)
        {
            X = x;
            Y = y;
        }

        /// <summary>
        /// moves the x and y values by the specified amount
        /// </summary>
        /// <param name="xOffset">how much to move the x value</param>
        /// <param name="yOffset">how much to move the y value</param>
        public void MoveBy(double xOffset, double yOffset)
        {
            X += xOffset;
            Y += yOffset;
        }

        /// <summary>
        /// checks to see if a point is contained within the circle
        /// </summary>
        /// <param name="position"></param>
        /// <returns></returns>
        public bool ContainsPosition(IPosition position)
        {
            if (Radius >= DistanceTo(position))
            {
                return true;
            }

            return false;
        }

        /// <summary>
        /// checks if an area is larger
        /// than the current area
        /// </summary>
        /// <param name="areaToCheck">area to be compared</param>
        /// <returns>true if it is, false otherwise</returns>
        public bool IsLargerThan(IArea areaToCheck)
        {
            if (areaToCheck.Area > Area)
            {
                return false;
            }

            return true;
        }

        /// <summary>
        /// overrides ToString to contain information about the circle
        /// </summary>
        /// <returns>the center of the circle's x and y values, 
        /// its radiues, area, and perimeter</returns>
        public override string ToString()
        {
            return $"Center of circle-  x: {X} y: {Y} Radius: {Radius} " +
                $"Area: {Area} Perimeter: {Perimeter}";
        }
    }
}
