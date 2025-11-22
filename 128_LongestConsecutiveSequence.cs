// https://leetcode.com/problems/longest-consecutive-sequence/description/


public class Solution
{
    public int LongestConsecutive(int[] nums)
    {
        HashSet<int> hashset = nums.ToHashSet();

        int maxCon = 0;

        foreach (var number in hashset)
        {
            if (!hashset.Contains(number - 1))
            {
                int i = 1;
                while (hashset.Contains(number + i))
                {
                    i++;
                }

                maxCon = Math.Max(maxCon, i);
            }
        }

        return maxCon;
    }
}
