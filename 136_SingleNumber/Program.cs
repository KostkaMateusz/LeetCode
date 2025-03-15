// https://leetcode.com/problems/single-number/description/

int[] nums = [2, 2, 1];

var sol = new Solution();


sol.SingleNumber(nums);

public class Solution
{
    public int SingleNumber(int[] nums)
    {
        HashSet<int> set = new HashSet<int>();

        foreach (var num in nums)
        {
            if (!set.Add(num))
            {
                set.Remove(num);
            }
        }

        return set.First();
    }
}