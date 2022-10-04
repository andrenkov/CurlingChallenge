namespace CurlingChallenge.Models
{
    /// <summary>
    /// Simple object to store x and y where x is read only
    /// </summary>
    public struct Coords
    {
        public Coords(double x, double y)
        {
            X = x;
            Y = y;
        }

        public double X { get; init; }//read only
        public double Y { get; set; }//will be updated
        
    }
}
