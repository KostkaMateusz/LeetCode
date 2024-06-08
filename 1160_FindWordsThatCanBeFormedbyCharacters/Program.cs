


var sol = new Solution();

sol.CountCharacters(["cat", "bt", "hat", "tree"],  "atach");


public class Solution
{
    public int CountCharacters(string[] words, string chars)
    {        
        var charCounts = chars.GroupBy(c => c).ToDictionary(g => g.Key, g => g.Count());

        int count = 0;

        foreach(var word in words)
        {
            var wordDict = word.GroupBy(c => c).ToDictionary(g => g.Key, g => g.Count());
            
            if(CheckIfCanBeFormed(wordDict, charCounts))
            {
                count += word.Length;
            }

        }

        return count;
    }

    private static bool CheckIfCanBeFormed(Dictionary<char,int> wordDict, Dictionary<char,int> charCounts)
    {
        foreach (var key in wordDict.Keys)
        {
            if (charCounts.TryGetValue(key, out int charValue))
            {
                if (charValue < wordDict[key])
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        return true;
    }
}