//https://leetcode.com/problems/how-many-numbers-are-smaller-than-the-current-number/description/

int[] nums = [8, 1, 2, 2, 3];

var sol = new Solution();

Console.WriteLine(sol.SmallerNumbersThanCurrent(nums));

public class Solution
{
    public int[] SmallerNumbersThanCurrent(int[] nums)
    {
        var numsSorted=nums.OrderBy(x => x).ToList();
        var output = new int[nums.Length];

        for(int i = 0; i < nums.Length; i++)
        {
            output[i] = numsSorted.IndexOf(nums[i]);
        }
        return output;
    }
}