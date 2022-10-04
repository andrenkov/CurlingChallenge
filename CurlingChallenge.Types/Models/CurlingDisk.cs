namespace CurlingChallenge.Models
{
    public class CurlingRock : Stone
    {
        public Coords startPos { get; set; }
        /// <summary>
        /// endPos is calculated in game class moving disks
        /// </summary>
        public Coords endPos { get; set; }

        /// <summary>
        /// Overloads the base class Constructor
        /// </summary>
        /// <param name="rad"></param>
        /// <param name="startCoord"></param>
        public CurlingRock(int rad, Coords startCoord) : base(rad) 
        {
            startPos = startCoord;
            movingBehavior = new SlidingRock();
        }
        /// <summary>
        /// Overloads the base DoMove()
        /// </summary>
        /// <param name="end"></param>
        public void DoMove(Coords end)
        {
            endPos = end;
        }
    }
}
