// https://leetcode.com/problems/minimum-number-of-operations-to-make-array-empty/

var sol = new Solution();

sol.MinOperations([2, 3, 3, 2, 2, 4, 2, 3, 4]);

public class Solution
{
    public int MinOperations(int[] nums)
    {
        Dictionary<int, int> dict = [];
        foreach (var num in nums)
        {
            if (!dict.TryAdd(num, 1))
            {
                dict[num]++;
            }
        }

        int counter = 0;

        foreach (var value in dict.Values)
        {
            if (value == 1)
            {
                return -1;
            }

            int divisionResult = value / 3;
            int divisionRest = value % 3;

            if (divisionRest == 0)
            {
                counter += divisionResult;
            }
            else
            {
                counter += divisionResult + 1;
            }
        }

        return counter;
    }
}