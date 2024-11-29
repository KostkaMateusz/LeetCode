// https://leetcode.com/problems/number-of-good-pairs/


public class Solution
{
    public int NumIdenticalPairs(int[] nums)
    {
        Dictionary<int, int> dict = [];

        int goodPairs = 0;

        foreach (var num in nums)
        {
            if (dict.TryAdd(num, 1) is false)
            {
                goodPairs += dict[num];
                dict[num]++;
            }
        }

        return goodPairs;
    }
}