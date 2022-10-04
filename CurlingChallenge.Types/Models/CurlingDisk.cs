using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurlingChallenge.Models
{
    public class CurlingRock : Stone
    {
        public Coords startPos { get; set; }
        public Coords endPos { get; set; }
        public CurlingRock(int rad, Coords startCoord) : base(rad) 
        {
            startPos = startCoord;
            movingBehavour = new SlidingRock();
        }

        public void DoMove(Coords end)
        {
            endPos = end;
        }
    }
}
