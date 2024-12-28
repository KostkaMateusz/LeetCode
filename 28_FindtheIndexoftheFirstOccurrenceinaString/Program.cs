// https://leetcode.com/problems/find-the-index-of-the-first-occurrence-in-a-string/


public class Solution
{
    public int StrStr(string haystack, string needle)
    {
        var hayStackSpan = haystack.AsSpan();

        var needleSpan = needle.AsSpan();

        return hayStackSpan.IndexOf(needleSpan);
    }
}