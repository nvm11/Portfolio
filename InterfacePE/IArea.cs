//Nathan McAndrew
//11/7/22
//Interface for shapes
namespace InterfacePE
{
    internal interface IArea
    {
        /// <summary>
        /// area of a circle
        /// </summary>
        double Area { get; }
        /// <summary>
        /// perimeter of a circle
        /// </summary>
        double Perimeter { get; }
        
        
        /// <summary>
        /// checks if a point is within an object's area
        /// </summary>
        /// <param name="distance">distance of the point from the cricle's radius</param>
        /// <returns></returns>
        bool ContainsPosition(IPosition distance);

        /// <summary>
        /// checks if the area is larger than 
        /// that of another object's
        /// </summary>
        /// <param name="areaToCheck">area being compared</param>
        /// <returns>true if yes, false otherwise</returns>
        bool IsLargerThan(IArea areaToCheck);

    }
}
