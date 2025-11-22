// https://leetcode.com/problems/redistribute-characters-to-make-all-strings-equal/description/

var sol = new Solution();

sol.MakeEqual(["abc", "aabc", "bc"]);

public class Solution
{
    public bool MakeEqual(string[] words)
    {
        Dictionary<char, int> characterCount = [];

        foreach (var word in words)
        {
            foreach (var character in word)
            {
                if (!characterCount.TryAdd(character, 1))
                {
                    characterCount[character]++;
                }
            }
        }

        foreach (var count in characterCount.Values)
        {
            if (count % words.Length != 0)
            {
                return false;
            }
        }

        return true;
    }
}
