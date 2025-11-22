// https://leetcode.com/problems/path-crossing/description/

var sol = new Solution();

sol.IsPathCrossing("NES");


public class Solution
{
    public bool IsPathCrossing(string path)
    {
        var currentPosition = (x: 0, y: 0);

        var positionHash = new HashSet<(int, int)>();

        positionHash.Add((currentPosition));

        for (int i = 0; i < path.Length; i++)
        {
            var currentMove = path[i];

            if (currentMove == 'N')
            {
                currentPosition.y += 1;
            }
            else if (currentMove == 'S')
            {
                currentPosition.y -= 1;
            }
            else if (currentMove == 'E')
            {
                currentPosition.x -= 1;
            }
            else if (currentMove == 'W')
            {
                currentPosition.x += 1;
            }

            if (!positionHash.Add((currentPosition)))
            {
                return true;
            }
        }

        return false;
    }
}
