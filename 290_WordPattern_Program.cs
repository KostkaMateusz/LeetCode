// https://leetcode.com/problems/word-pattern/

public class Solution
{
    public bool WordPattern(string pattern, string s)
    {
        string[] sArray = s.Split(" ");
        Dictionary<char, string> map = [];

        if (pattern.Length != sArray.Length)
        {
            return false;
        }

        for (int i = 0; i < pattern.Length; i++)
        {
            if (!map.ContainsKey(pattern[i]))
            {
                if (!map.ContainsValue(sArray[i]))
                {
                    map.Add(pattern[i], sArray[i]);
                }
                else
                {
                    return false;
                }
            }
            else
            {
                if (map[pattern[i]] != sArray[i])
                {
                    return false;
                }
            }
        }

        return true;
    }
}
