//https://leetcode.com/problems/number-of-good-pairs/description/
var sol = new Solution();
var nums = new int[] { 1, 2, 3, 1, 1, 3 };
nums = new int[] { 1,1,1 };
Console.WriteLine(sol.NumIdenticalPairs(nums));


public class Solution
{
    public int NumIdenticalPairs(int[] nums)
    {
        Dictionary<int, int> dict =new ();
        int goodPairs = 0;
        
        foreach (int num in nums)
        {
            if (dict.TryGetValue(num, out int value))
            {
                goodPairs += value;
                dict[num] = ++value;
            }
            else
            {
                dict[num] = 1;
            }
        }

        return goodPairs;
    }
}