// https://leetcode.com/problems/maximum-distance-in-arrays/

public class Solution
{
    public int MaxDistance(IList<IList<int>> arrays)
    {

        int globalMin = int.MaxValue;
        int globalMax = int.MinValue;
        int minIndex = -1;
        int maxIndex = -1;


        for (int i = 0; i < arrays.Count; i++)
        {
            int currentMin = arrays[i][0];
            int currentMax = arrays[i][^1];

            if (currentMin < globalMin)
            {
                globalMin = currentMin;
                minIndex = i;
            }

            if (currentMax > globalMax)
            {
                globalMax = currentMax;
                maxIndex = i;
            }
        }


        int maxDistance = 0;
        for (int i = 0; i < arrays.Count; i++)
        {
            if (i != minIndex)
            {
                maxDistance = Math.Max(maxDistance, Math.Abs(arrays[i][^1] - globalMin));
            }

            if (i != maxIndex)
            {
                maxDistance = Math.Max(maxDistance, Math.Abs(arrays[i][0] - globalMax));
            }
        }

        return maxDistance;
    }
}