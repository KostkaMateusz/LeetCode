// https://leetcode.com/problems/number-of-pairs-of-interchangeable-rectangles/description/

var sol = new Solution();

sol.InterchangeableRectangles([[4, 8], [3, 6], [10, 20], [15, 30]]);


public class Solution
{
    public long InterchangeableRectangles(int[][] rectangles)
    {
        Dictionary<double, int> hashMap = [];
        long count = 0;

        foreach (var rectangle in rectangles)
        {
            double ratio = (double)rectangle[0] / rectangle[1];

            // If we check it again that means what we have second number for pair
            if (hashMap.TryGetValue(ratio, out var value))
            {
                count += value;
                hashMap[ratio] = value + 1;
            }
            else
            {
                hashMap[ratio] = 1;
            }
        }

        return count;
    }
}