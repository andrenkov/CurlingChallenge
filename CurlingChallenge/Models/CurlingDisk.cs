using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurlingChallenge.Models
{
    public class CurlingRock : Stone
    {
        public Coords _start { get; set; }
        public Coords _end { get; set; }
        public CurlingRock(int rad, Coords startCoord) : base(rad) 
        {
            _start = startCoord;
            movingBehavour = new SlidingRock();
        }

        public void DoMove(Coords end)
        {
            _end = end;
        }
    }
}
