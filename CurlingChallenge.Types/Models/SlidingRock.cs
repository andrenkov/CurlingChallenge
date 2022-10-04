namespace CurlingChallenge.Models
{
    public class SlidingRock : IStoneMoveBehavior
    {
        /// <summary>
        /// This DoMove() is overloaded in the CurlingDisk child class
        /// </summary>
        public void DoMove()
        {
            Console.WriteLine("Sliding a rock");
        }
    }
}
