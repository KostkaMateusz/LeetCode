//https://leetcode.com/problems/running-sum-of-1d-array/description/

public class Solution
{
    public int[] RunningSum(int[] nums)
    {
        int currentSum = 0;
        for(int i = 0; i < nums.Length; i++)
        {
            currentSum += nums[i];
            nums[i] = currentSum;
        }
        return nums;
    }
}