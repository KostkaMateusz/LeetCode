// https://leetcode.com/problems/minimum-distance-to-the-target-element/?envType=daily-question&envId=2026-04-13

public class Solution
{
    public int GetMinDistance(int[] nums, int target, int start)
    {

        var Minimum = int.MaxValue;

        for (int i = start; i >= 0; i--)
        {
            if (nums[i] == target)
            {
                Minimum = Math.Min(Minimum, Math.Abs(i - start));
                break;
            }
        }

        for (int i = start; i < nums.Length; i++)
        {
            if (nums[i] == target)
            {
                Minimum = Math.Min(Minimum, Math.Abs(i - start));
                break;
            }
        }

        return Minimum;

    }
}