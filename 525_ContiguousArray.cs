// https://leetcode.com/problems/contiguous-array/description/


var sol = new Solution();

sol.FindMaxLength([0, 1, 0]);

public class Solution
{
    public int FindMaxLength(ReadOnlySpan<int> nums)
    {
        int res = 0;
        int diff = 0;

        // handle the case when entire subarray from start is valid
        Dictionary<int, int> dict = new() { { 0, -1 } };

        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] == 1)
            {
                diff++;
            }
            else
            {
                diff--;
            }

            if (!dict.TryAdd(diff, i))
            {
                res = Math.Max(res, i - dict[diff]);
            }
        }

        return res;
    }
}
