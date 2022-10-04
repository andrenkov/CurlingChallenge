using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurlingChallenge.Models
{
    public class SlidingRock : IStoneMoveBehavour
    {
        public void DoMove()
        {
            Console.WriteLine("Sliding a rock");
            //Display stone here
        }
    }
}
