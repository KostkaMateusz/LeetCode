// https://leetcode.com/problems/isomorphic-strings/

// "badc"
// "baba"

public class Solution
{
    public bool IsIsomorphic(string s, string t)
    {
        Dictionary<char, char> map = [];

        for (int i = 0; i < s.Length; i++)
        {
            if (map.TryGetValue(s[i], out char mappedValue))
            {
                if (mappedValue != t[i])
                {
                    return false;
                }
                
            }else if (!map.ContainsValue(t[i]))
            {
                map[s[i]] = t[i];
            }
            else
            {
                return false;
            }
        }

        return true;
    }
}