using CurlingChallenge;
using CurlingChallenge.Models;

int width = 1000;
double height = Math.Pow(10, 100);

Console.WriteLine("Enter the number of disks:");
int n = Convert.ToInt32(Console.ReadLine().Trim());

Console.WriteLine("Enter the disk radius:");
int r = Convert.ToInt32(Console.ReadLine().Trim());

if (!ValiadateInput())
{
    Console.WriteLine("Invalid input");
    return;
}

Random randNum = new Random();
int[] xCoordinates = Enumerable
    .Repeat(0, n)
    .Select(i => randNum.Next(r, width))
    .ToArray();

//for Unit Test
//n = 5;
//r = 100;
//int[] xCoordinates = new[] { 100, 300, 500, 700, 900};//100, 100, 100, 100, 100
//int[] xCoordinates = new[] { 100, 100, 100, 100, 100 };//100, 300, 500, 700, 900
//int[] xCoordinates = new[] { 100, 100, 100, 200, 200 };//100, 300, 500, 673.2050807568877, 873.2050807568877
//int[] xCoordinates = new[] { 100, 100, 100, 300, 300 };//100, 300, 500, 100, 300
//int[] xCoordinates = new[] { 100, 100, 100, 300, 350 };//100, 300, 500, 100, 293.64916731037084
//int[] xCoordinates = new[] { 100, 150, 200, 250, 300 };//100, 293.64916731037084, 487.2983346207417, 680.9475019311126, 874.5966692414834
//int[] xCoordinates = new[] { 100, 150, 200, 250, 700 };//100, 293.64916731037084, 487.2983346207417, 680.9475019311126, 100


bool ValiadateInput()
{
    return (n >= 1) && (r > 0) && (r < 1000) && (n < 1000);
}

Console.WriteLine(string.Join(", ", xCoordinates));

List<CurlingRock> disks = new();

foreach (int diskX in xCoordinates)
{

    Coords startCoords = new(diskX, height);
    CurlingRock CurlDisk = new(r, startCoords);
    disks.Add(CurlDisk);//set end position and display in UI
}

game g = new game(width, height, r, disks);
g.PlayGame();

double[] result = g.disksList
        .Select(disk => disk._end.Y)
        .ToArray();
Console.WriteLine(string.Join(", ", result));



//////////////////////////////////////////////////////////////////////////
Console.Write("\nPress any key to continue... ");
Console.ReadLine();

