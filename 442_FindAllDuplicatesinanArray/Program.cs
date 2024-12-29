// https://leetcode.com/problems/find-all-duplicates-in-an-array/description/

var sol = new Solution();

sol.FindDuplicates([4, 3, 2, 7, 8, 2, 3, 1]);


public class Solution
{
    public IList<int> FindDuplicates(Span<int> nums)
    {
        IList<int> result = [];

        for (int i = 0; i < nums.Length; i++)
        {
            var n = Math.Abs(nums[i]);

            if (nums[n - 1] < 0)
            {
                result.Add(n);
            }

            nums[n - 1] *= (-1);
        }

        return result;
    }
}