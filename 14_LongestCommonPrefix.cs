// https://leetcode.com/problems/longest-common-prefix/description/

var sol = new Solution();

string[] trs = ["flower", "flow", "flight"];

var output = sol.LongestCommonPrefix(trs);

Console.WriteLine(output);

public class Solution
{
    public string LongestCommonPrefix(string[] strs)
    {
        var prefixCandidate = strs[0];

        var maxPrefix = int.MaxValue;

        foreach (var word in strs)
        {
            var localMaxPrefix = 0;

            for (int i = 0; i < Math.Min(prefixCandidate.Length, word.Length); i++)
            {
                if (prefixCandidate[i] == word[i])
                    localMaxPrefix++;
                else
                    break;
            }

            maxPrefix = Math.Min(maxPrefix, localMaxPrefix);
        }

        return prefixCandidate[..maxPrefix];
    }
}
