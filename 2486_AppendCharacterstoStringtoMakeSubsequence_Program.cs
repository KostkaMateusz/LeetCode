// https://leetcode.com/problems/append-characters-to-string-to-make-subsequence/

var sol = new Solution();

Console.WriteLine(sol.AppendCharacters(s: "coaching", t: "coding"));
Console.WriteLine(sol.AppendCharacters(s: "abcde", t: "a"));
Console.WriteLine(sol.AppendCharacters(s: "z", t: "abcde"));

public class Solution
{
    public int AppendCharacters(string s, string t)
    {
        int sPointer = 0;
        int tPointer = 0;


        while (sPointer < s.Length && tPointer < t.Length)
        {
            if (s[sPointer] == t[tPointer])
            {
                tPointer++;
            }

            sPointer++;

        }

        return t.Length - tPointer;

    }
}
