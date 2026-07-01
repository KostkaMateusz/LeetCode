// https://leetcode.com/problems/minimum-distance-to-the-target-element/?envType=daily-question&envId=2026-04-13

public class Solution
{
    public int GetMinDistance(int[] nums, int target, int start)
    {
        int distance = int.MaxValue;


        for (int i = 0; i < nums.Length; i++)
        {
            if (start + i < nums.Length)
            {
                if (nums[start + i] == target)
                {
                    distance = Math.Min(distance, Math.Abs(start + i - start));
                    break;
                }
            }

            if (start - i >= 0)
            {
                if (nums[start - i] == target)
                {
                    distance = Math.Min(distance, Math.Abs(start - i - start));
                    break;
                }
            }

        }
        return distance;
    }
}