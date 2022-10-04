///
/// This is a Console app which takes two inputs from a user, calls the game class to calculate the positions of the disks 
/// and prints the result  
///
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
///
///Builds the list of random X coordinates
///
Random randNum = new Random();
int[] xCoordinates = Enumerable
    .Repeat(0, n)
    .Select(i => randNum.Next(r, width))
    .ToArray();
///
///Checks min-max
///
bool ValiadateInput()
{
    return (n >= 1) && (r > 0) && (r < 1000) && (n < 1000);
}

///
///Initializing the list of Disks with random X
///
List<CurlingRock> disks = new();
foreach (int diskX in xCoordinates)
{

    Coords startCoords = new(diskX, height);
    CurlingRock CurlDisk = new(r, startCoords);
    disks.Add(CurlDisk);
}
///
///game is the class to calculate the positions of the disks moving them to Y=0
///
game g = new game(width, height, r, disks);
g.PlayGame();
///
///Printing the result
///
double[] result = g.disksList
        .Select(disk => disk.endPos.Y)
        .ToArray();
Console.WriteLine(string.Join(", ", result));


//////////////////////////////////////////////////////////////////////////
//Console.Write("\nPress any key to continue... ");
//Console.ReadLine();

