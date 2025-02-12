// https://leetcode.com/problems/sum-of-absolute-differences-in-a-sorted-array/description/

public class Solution
{
    public int[] GetSumAbsoluteDifferences(int[] nums)
    {
        var sum = nums.Sum();

        int[] output = new int[nums.Length];

        for (int i = 0; i < nums.Length; i++)
        {
            output[i] = sum - (nums[i] * nums.Length);
        }

        return output;
    }
}