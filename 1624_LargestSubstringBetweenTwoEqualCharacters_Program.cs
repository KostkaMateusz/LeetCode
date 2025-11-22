// https://leetcode.com/problems/largest-substring-between-two-equal-characters/

var sol = new Solution();
sol.MaxLengthBetweenEqualCharacters("cabbac");

public class Solution
{
    public int MaxLengthBetweenEqualCharacters(string s)
    {
        Dictionary<char, int> map = [];
        int max = -1;

        for (int i = 0; i < s.Length; i++)
        {
            if (map.TryGetValue(s[i], out int index))
            {
                max = Math.Max(max, i - index - 1);
            }
            else
            {
                map.Add(s[i], i);
            }
        }

        return max;
    }
}
