using CurlingChallenge.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurlingChallenge
{
    public class game
    {
        private readonly int planeWidth;
        private readonly double planeHeight;
        private readonly int diskRadius;
        public List<CurlingRock> disksList { get; set; }
        public game(int planewidth, double planeheight, int diskradius, List<CurlingRock> diskslist)
        {
            planeWidth = planewidth;   
            planeHeight = planeheight; 
            diskRadius = diskradius;   
            disksList = diskslist;
        }

        public void PlayGame()
        {
            foreach (CurlingRock disk in disksList)
            {
                disk.DoMove(SlideToTopAndCheck(disk));//find the stop coordinates display the disk accordingly
            }
        }

        private Coords SlideToTopAndCheck(CurlingRock disk)
        {
            Coords result = new(disk.startPos.X, diskRadius);

            //select all disk in the corridor
            List<CurlingRock> corridorDisks = disksList.Where(d => (d.endPos.Y > 0) 
                          && d.startPos.X > (disk.startPos.X - diskRadius*2) && (d.startPos.X < (disk.startPos.X + diskRadius*2)))
                .OrderByDescending(d => d.endPos.Y)//OrderByDescending
                .ToList();
            //if nothing in the corridor then move to the end 
            if (corridorDisks.Count == 0)
            {
                result.Y = diskRadius;
            }
            else//calc where it touches the closest rock
            {
                CurlingRock rock = corridorDisks.First();//the closest one
                if (true)// (GetDistance(rock._end, disk._end) < (diskRadius * 2))
                {
                    double horriz = Math.Abs(rock.endPos.X - disk.startPos.X);
                    double vert = rock.endPos.Y + Math.Sqrt(Math.Pow(diskRadius*2, 2) - Math.Pow(horriz, 2));

                    result.Y = vert;
                }
            }

            return result;
        }

        private double GetDistance(Coords c1, Coords c2)
        {
            return Math.Sqrt(Math.Pow(c1.X - c2.X, 2) + Math.Pow(c1.Y - c2.Y, 2));

        }
    }
}
