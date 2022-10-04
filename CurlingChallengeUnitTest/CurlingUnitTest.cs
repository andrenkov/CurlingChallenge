using CurlingChallenge;
using CurlingChallenge.Models;
using Xunit;

namespace CurlingChallengeUnitTest
{
    public class CurlingUnitTest
    {
        [Fact]
        public void TestGameTopDisk()
        {
            //arrange
            int width = 1000;
            double height = Math.Pow(10, 100);
            int n = 5;
            int r = 100;
            double expected = 100;

            int[] xCoordinates = new[] { 100, 150, 200, 250, 700 };//100, 293.64916731037084, 487.2983346207417, 680.9475019311126, 100
            List<CurlingRock> disks = new();

            foreach (int diskX in xCoordinates)
            {

                Coords startCoords = new(diskX, height);
                CurlingRock CurlDisk = new(r, startCoords);
                disks.Add(CurlDisk);
            }

            game g = new game(width, height, r, disks);

            //Act
            g.PlayGame();

            //Assert
            Assert.Equal(expected, g.disksList[0]._end.Y);
        }

        [Fact]
        public void TestGameDiskCollide()
        {
            //arrange
            int width = 1000;
            double height = Math.Pow(10, 100);
            int n = 5;
            int r = 100;
            double expected = 293.64916731037084;

            int[] xCoordinates = new[] { 100, 150, 200, 250, 700 };//100, 293.64916731037084, 487.2983346207417, 680.9475019311126, 100
            List<CurlingRock> disks = new();

            foreach (int diskX in xCoordinates)
            {

                Coords startCoords = new(diskX, height);
                CurlingRock CurlDisk = new(r, startCoords);
                disks.Add(CurlDisk);
            }

            game g = new game(width, height, r, disks);

            //Act
            g.PlayGame();

            //Assert
            Assert.Equal(expected, g.disksList[1]._end.Y);
        }
    }
}