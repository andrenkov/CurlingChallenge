namespace CurlingChallenge.Models
{
    /// <summary>
    /// Super class for all stones. The weight property isn't in use and added just to have something other than Radius  
    /// </summary>
    public abstract class Stone
    {
        public int _radius { get; set; }
        public int _weigth { get; set; }//future use
        /// <summary>
        /// The moving behavior implements in SlidingRock and PlainRock classes to make use of the polymorphism 
        /// </summary>
        public IStoneMoveBehavior movingBehavior { get; set; }

        /// <summary>
        /// Constructor of the base class
        /// </summary>
        /// <param name="rad"></param>
        /// <param name="weight"></param>
        public Stone(int rad, int weight = 0)
        {
            _radius = rad;
            _weigth = weight;
        }

        public void MoveStone()
        {
            movingBehavior.DoMove();
        }
    }
}
