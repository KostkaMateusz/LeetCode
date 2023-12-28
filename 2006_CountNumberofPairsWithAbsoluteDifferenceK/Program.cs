//https://leetcode.com/problems/count-number-of-pairs-with-absolute-difference-k/description/


public class Solution
{
    public int CountKDifference(int[] nums, int k)
    {
        var countOfPairs = 0;

        for (int leftPointer = 0; leftPointer < nums.Length; leftPointer++)
        {
            for (int rightPointer = leftPointer; rightPointer < nums.Length; rightPointer++)
            {
                if (Math.Abs(nums[leftPointer] - nums[rightPointer]) == k)
                {
                    countOfPairs++;
                }
            }
        }
        return countOfPairs;
    }
}