// https://leetcode.com/problems/is-subsequence/

var sol = new Solution();

Console.WriteLine(sol.IsSubsequence("b", "c"));


Console.WriteLine();

public class Solution
{
    public bool IsSubsequence(string s, string t)
    {
        var sPointer = 0;

        if (string.IsNullOrEmpty(s))
            return true;

        for (int i = 0; i < t.Length; i++)
        {
            if (s[sPointer] == t[i])
                sPointer++;

            if (sPointer == s.Length)
                return true;
        }

        return false;
    }
}
