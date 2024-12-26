// https://leetcode.com/problems/unique-length-3-palindromic-subsequences/description/

var sol = new Solution();

sol.CountPalindromicSubsequence(s: "bbcbaba");

public class Solution
{
    public int CountPalindromicSubsequence(string s)
    {
        int palindromeCount = 0;

        for (char c = 'a'; c <= 'z'; c++)
        {
            int left = s.IndexOf(c);
            int right = s.LastIndexOf(c);

            HashSet<char> mids = [];

            for (int i = left + 1; i < right; i++)
            {
                mids.Add(s[i]);
            }

            palindromeCount += mids.Count;
        }

        return palindromeCount;
    }
}