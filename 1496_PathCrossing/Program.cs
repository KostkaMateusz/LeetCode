

var sol = new Solution();

Console.WriteLine(sol.IsPathCrossing("NES"));

Console.WriteLine(sol.IsPathCrossing("NESWW"));



public class Solution
{
    public bool IsPathCrossing(string path)
    {
        var directions = new Dictionary<char, (int, int)>()
        {
            {'N' , (0,1) },
            {'S', (0,-1) },
            {'E', (-1,0) },
            {'W', (1,0)  }
        };
     
        var positionTracker = new HashSet<(int, int)>() { (0,0) };

        int pointX = 0;
        int pointY = 0;
        
        foreach (var move in path)
        {
            var (dx, dy) = directions[move];

            pointX += dx;
            pointY += dy;

            if (positionTracker.Contains((pointX, pointY)))
            {
                return true;
            }
            else
            {
                positionTracker.Add((pointX, pointY));
            }
        }
        return false;
    }
}