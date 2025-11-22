// https://leetcode.com/problems/brick-wall/description/

var sol = new Solution();

sol.LeastBricks([[1, 2, 2, 1], [3, 1, 2], [1, 3, 2], [2, 4], [3, 1, 2], [1, 3, 1, 1]]);


public class Solution
{
    public int LeastBricks(IList<IList<int>> wall)
    {
        Dictionary<int, int> craks = [];
        int maxCraks = 0;


        for (var index = 0; index < wall.Count; index++)
        {
            var row = wall[index];
            var incrementalIndex = 0;
            for (var j = 0; j < row.Count - 1; j++)
            {
                incrementalIndex += row[j];

                if (!craks.TryAdd(incrementalIndex, 1))
                {
                    craks[incrementalIndex]++;
                }

                maxCraks = Math.Max(maxCraks, craks[incrementalIndex]);
            }
        }


        return wall.Count - maxCraks;
    }
}
