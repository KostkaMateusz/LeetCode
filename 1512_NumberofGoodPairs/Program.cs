//https://leetcode.com/problems/number-of-good-pairs/description/
var sol = new Solution();
var nums = new int[] { 1, 2, 3, 1, 1, 3 };
Console.WriteLine(sol.NumIdenticalPairs(nums));


public class Solution
{
    public int NumIdenticalPairs(int[] nums)
    {
        Dictionary<int, int> dict =new ();
        int goodPairs = 0;
        
        foreach (int num in nums)
        {
            if (dict.ContainsKey(num))
            {
                goodPairs += dict[num];
                dict[num]++;
            }
            else
            {
                dict[num] = 1;
            }
        }

        return goodPairs;
    }
}