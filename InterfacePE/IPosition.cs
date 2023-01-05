//Nathan McAndrew
//11/7/22
//Interface for points
namespace InterfacePE
{
    internal interface IPosition
    {
        /// <summary>
        /// x position of a point
        /// </summary>
        double X { get; set; }
        
        /// <summary>
        /// y position of a point
        /// </summary>
        double Y { get; set; }


        /// <summary>
        /// obtains the distance from one coordinate
        /// to another through a formula
        /// </summary>
        /// <param name="position">x and y coordinates of a point</param>
        /// <returns>distance from onw cooedinate to another</returns>
        double DistanceTo(IPosition position);
        
        /// <summary>
        /// moves a coordinate to another
        /// </summary>
        /// <param name="x">new x coordinate</param>
        /// <param name="y">new y coordinate</param>
        void MoveTo(double x, double y);

        /// <summary>
        /// moves a point by the specified value
        /// </summary>
        /// <param name="xOffset">how many to adjust x value</param>
        /// <param name="yOffset">how many to adjust y value</param>
        void MoveBy(double xOffset, double yOffset);
    }
}
