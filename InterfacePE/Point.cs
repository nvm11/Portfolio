//Nathan McAndrew
//11/7/22
//class with the properties of a point

namespace InterfacePE
{
    internal class Point : IPosition
    {
        private double x;
        private double y;

        /// <summary>
        /// creates a points and initializes its coordinates
        /// </summary>
        /// <param name="x">x coordinate</param>
        /// <param name="y">y coordinate</param>
        public Point(double x, double y)
        {
            this.x = x;
            this.y = y;
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
        /// overrides ToString() to display informaiton
        /// related to the point's data
        /// </summary>
        /// <returns>x and y coordinates of the point</returns>
        public override string ToString()
        {
            return $"Point x: {X} y: {Y}";
        }
    }
}
