//https://leetcode.com/problems/concatenation-of-array/description/
var sol = new Solution();
var input = new[] { 1, 2, 1 };

Console.WriteLine(sol.GetConcatenation(input));


public class Solution
{
    public int[] GetConcatenation(int[] nums)
    {
        return nums.Concat(nums).ToArray();
    }
}