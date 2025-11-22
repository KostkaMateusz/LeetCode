// https://leetcode.com/problems/first-unique-character-in-a-string/description/


var sol = new Solution();

sol.FirstUniqChar("leetcode");

public class Solution
{
    public int FirstUniqChar(string s)
    {
        Dictionary<char, int> dic = [];

        for (int i = 0; i < s.Length; i++)
        {
            var c = s[i];
            if (!dic.TryAdd(c, i))
            {
                dic[c] = int.MaxValue;
            }
        }

        var result = dic.Values.Min();

        if (result == int.MaxValue)
        {
            result = -1;
        }

        return result;
    }
}
