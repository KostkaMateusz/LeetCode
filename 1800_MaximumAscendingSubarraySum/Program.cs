// https://leetcode.com/problems/maximum-ascending-subarray-sum/

var sol = new Solution();

sol.MaxAscendingSum([10, 20, 30, 40, 50]);
sol.MaxAscendingSum([10, 20, 30, 5, 10, 50]);


public class Solution
{
    public int MaxAscendingSum(int[] nums)
    {
        var sum = nums[0];
        var maxSum = sum;

        for (int i = 1; i < nums.Length; i++)
        {
            if (nums[i] > nums[i - 1])
            {
                sum += nums[i];
            }
            else
            {
                sum = nums[i];
            }
            maxSum = Math.Max(maxSum, sum);

        }
        return maxSum;
    }
}

