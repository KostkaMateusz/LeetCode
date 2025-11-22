// https://leetcode.com/problems/longest-palindrome/description/

public class Solution
{
    public int LongestPalindrome(string s)
    {
        Dictionary<char, int> charCount = new();

        foreach (char c in s)
        {
            if (!charCount.TryAdd(c, 1))
            {
                charCount[c] += 1;
            }
        }


        int length = 0;
        bool hasOdd = false;

        foreach (var count in charCount.Values)
        {
            length += count / 2 * 2;
            if (count % 2 == 1)
            {
                hasOdd = true;
            }
        }

        if (hasOdd)
        {
            length += 1;
        }

        return length;

    }
}
