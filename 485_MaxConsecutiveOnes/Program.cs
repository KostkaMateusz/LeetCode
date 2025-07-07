// https://leetcode.com/problems/max-consecutive-ones/description/

public class Solution
{
    public int FindMaxConsecutiveOnes(int[] nums)
    {
        int max1counts = 0;
        int current1Counts = 0;


        foreach (int num in nums)
        {
            if (num == 1)
            {
                current1Counts++;
            }
            else
            {
                max1counts = Math.Max(max1counts, current1Counts);
                current1Counts = 0;
            }
        }
        max1counts = Math.Max(max1counts, current1Counts);
        return max1counts;

    }
}