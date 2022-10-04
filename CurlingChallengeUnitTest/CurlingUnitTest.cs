using CurlingChallenge;
using CurlingChallenge.Models;

namespace CurlingChallengeUnitTest
{
    /// <summary>
    /// Basic Unit Test class to validate two cases (see below)
    /// </summary>
    public class CurlingUnitTest
    {
        /// <summary>
        /// This disk should be at top line
        /// </summary>
        [Fact]
        public void TestGameTopDisk()
        {
            //arrange
            int width = 1000;
            double height = Math.Pow(10, 100);
            int n = 5;
            int r = 100;
            double expected = 100;

            int[] xCoordinates = new[] { 100, 150, 200, 250, 700 };
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
            Assert.Equal(expected, g.disksList[0].endPos.Y);
        }

        /// <summary>
        /// This tests a collision with other disks situation
        /// </summary>
        [Fact]
        public void TestGameDiskCollide()
        {
            //arrange
            int width = 1000;
            double height = Math.Pow(10, 100);
            int n = 5;
            int r = 100;
            double expected = 293.64916731037084;

            int[] xCoordinates = new[] { 100, 150, 200, 250, 700 };
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
            Assert.Equal(expected, g.disksList[1].endPos.Y);
        }
    }
}