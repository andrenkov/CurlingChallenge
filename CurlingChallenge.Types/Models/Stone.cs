using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CurlingChallenge.Models
{
    public abstract class Stone
    {
        public int _radius { get; set; }
        public int _weigth { get; set; }//future use
        public IStoneMoveBehavour movingBehavour { get; set; }

        public Stone(int rad, int weight = 0)
        {
            _radius = rad;
            _weigth = weight;
        }

        public void MoveStone()
        {
            movingBehavour.DoMove();
        }
    }
}
