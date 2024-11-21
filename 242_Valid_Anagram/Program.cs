// https://leetcode.com/problems/valid-anagram/description/


public class Solution
{
    public bool IsAnagram(string s, string t)
    {
        if (s.Length != t.Length)
            return false;

        Dictionary<char, int> sMap = new();

        foreach (var character in s)
        {
            if (sMap.TryAdd(character, 1) is false)
                sMap[character]++;
        }

        foreach (var character in t)
        {
            if (sMap.ContainsKey(character))
            {
                sMap[character]--;
            }
            else
            {
                return false;
            }

            if (sMap[character] < 0)
                return false;
        }

        return true;
    }
}