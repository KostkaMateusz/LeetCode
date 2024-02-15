// https://leetcode.com/problems/merge-strings-alternately/

using System.Text;

var sol = new Solution();
Console.WriteLine(sol.MergeAlternately("abc", "pqr"));
Console.WriteLine(sol.MergeAlternately("abcd", "pq"));


public class Solution
{
    public string MergeAlternately(string word1, string word2)
    {
        var iterator1 = 0;
        var iterator2 = 0;

        StringBuilder mergedString = new();

        while (iterator1 < word1.Length && iterator2 < word2.Length)
        {
            mergedString.Append(word1[iterator1]);

            mergedString.Append(word2[iterator2]);

            iterator1++;
            iterator2++;
        }

        mergedString.Append(word1[iterator1..]);
        mergedString.Append(word2[iterator2..]);

        return mergedString.ToString();
    }
}