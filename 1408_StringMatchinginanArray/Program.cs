// https://leetcode.com/problems/string-matching-in-an-array/description/

public class Solution
{
    public IList<string> StringMatching(string[] words)
    {
        var resoults = new List<string>();

        for (int i = 0; i < words.Length; i++)
        {
            for (int j = 0; j < words.Length; j++)
            {
                if (i == j)
                    continue;

                if (words[j].Contains(words[i]))
                {
                    resoults.Add(words[i]);
                    // break;
                }

            }
        }
        return resoults;
    }
}