// https://leetcode.com/problems/isomorphic-strings/

var sol = new Solution();
sol.IsIsomorphic("egg", "add");



public class Solution
{
    public bool IsIsomorphic(string s, string t)
    {
        Dictionary<char, char> characterMap = new();

        for (var i = 0; i < s.Length; i++)
        {
            if (characterMap.TryGetValue(s[i], out var letter))
            {
                if (letter != t[i])
                {
                    return false;
                }
                continue;
            }

            if (characterMap.ContainsValue(t[i]))
            {
                return false;
            }
            
            characterMap.Add(s[i], t[i]);
        }
        return true;
    }
}