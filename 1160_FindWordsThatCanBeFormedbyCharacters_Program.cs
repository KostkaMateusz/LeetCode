// https://leetcode.com/problems/find-words-that-can-be-formed-by-characters/description/

var sol = new Solution();

sol.CountCharacters(words: ["cat", "bt", "hat", "tree"], chars: "atach");

public class Solution
{
    public int CountCharacters(string[] words, string chars)
    {
        //Chars Dictionary
        Dictionary<char, int> dict = [];

        foreach (var c in chars)
        {
            if (!dict.TryAdd(c, 1))
            {
                dict[c]++;
            }
        }

        int sum = 0;

        foreach (var word in words)
        {
            bool dictionaryMatch = true;

            var localDict = new Dictionary<char, int>(dict);
            foreach (var wc in word)
            {
                if (localDict.TryGetValue(wc, out var count))
                {
                    if (count == 0)
                    {
                        dictionaryMatch = false;
                        break;
                    }

                    localDict[wc]--;
                }
                else
                {
                    dictionaryMatch = false;
                    break;
                }
            }

            if (dictionaryMatch)
            {
                sum += word.Length;
            }
        }

        return sum;
    }
}
