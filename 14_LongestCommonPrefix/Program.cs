// https://leetcode.com/problems/longest-common-prefix/

using System.Text;

var sol = new Solution();

sol.LongestCommonPrefix(["flower", "flow", "flight"]);

public class Solution
{
    public string LongestCommonPrefix(string[] strs)
    {
        var preFixCount = new int[strs[0].Length];
        Array.Fill(preFixCount, 0);
        var stringZero = strs[0];

        foreach (var word in strs)
        {
            for (var i = 0; i < stringZero.Length && i < word.Length; i++)
            {
                if (word[i] == stringZero[i])
                    preFixCount[i]++;
                else
                    break;
            }
        }
        
        int elements = 0;
        foreach (var t in preFixCount)
        {
            if (t ==  strs.Length)
                elements++;
            else
                break;
        }
        return stringZero[..elements];
    }
}