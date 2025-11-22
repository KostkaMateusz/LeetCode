// https://leetcode.com/problems/maximum-difference-between-even-and-odd-frequency-i/

var sol = new Solution();

sol.MaxDifference("mmsmsym");


public class Solution
{
    public int MaxDifference(string s)
    {

        int[] counts = new int[26];

        foreach (char character in s)
        {
            counts[character - 'a'] += 1;
        }


        int maxOdd = Int32.MinValue;
        int minEven = Int32.MaxValue;


        foreach (int c in counts)
        {
            if (c != 0)
            {
                if (c % 2 == 0)
                {
                    minEven = Math.Min(c, minEven);
                }
                else
                {
                    maxOdd = Math.Max(c, maxOdd);
                }
            }
        }
        return maxOdd - minEven;

    }
}
