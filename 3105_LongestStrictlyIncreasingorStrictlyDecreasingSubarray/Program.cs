// https://leetcode.com/problems/longest-strictly-increasing-or-strictly-decreasing-subarray/

public class Solution
{
    public int LongestMonotonicSubarray(int[] nums)
    {

        int currentIncreasing = 1;
        int currentDecreasing = 1;
        int maxDecrasing = 1;
        int maxIncresing = 1;


        for (int i = 1; i < nums.Length; i++)
        {

            if (nums[i] > nums[i - 1])
            {
                currentIncreasing += 1;
                currentDecreasing = 1;
            }
            else if (nums[i] < nums[i - 1])
            {
                currentDecreasing += 1;
                currentIncreasing = 1;

            }
            else
            {
                currentDecreasing = 1;
                currentIncreasing = 1;

            }


            maxDecrasing = Math.Max(maxDecrasing, currentDecreasing);
            maxIncresing = Math.Max(maxIncresing, currentIncreasing);

        }


        return Math.Max(maxDecrasing, maxIncresing);

    }
}