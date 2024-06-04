var sol = new Solution();



Console.WriteLine(sol.WordPattern(pattern: "abba", s: "dog cat cat dog"));
Console.WriteLine(sol.WordPattern(pattern: "abba", s: "dog dog dog dog"));

public class Solution
{
    public bool WordPattern(string pattern, string s)
    {
        var words = s.Split(' ');

        if (words.Length != pattern.Length)
            return false;

        var patternToWord = new Dictionary<char, string>();
        var wordToPattern = new Dictionary<string, char>();
     
        
        for (int i = 0; i < pattern.Length; i++)
        {
            if (!patternToWord.TryGetValue(pattern[i], out string? value))
            {
                patternToWord[pattern[i]] = words[i];
            }
            else if (value != words[i])
            {
                return false;
            }



            patternToWord.TryAdd('a', "b");
            patternToWord.TryAdd('a', "c");

            patternToWord['a'];
            
            if (!wordToPattern.TryGetValue(words[i], out char valuePattern))
            {
                wordToPattern[words[i]] = pattern[i];
            }
            else if (valuePattern != pattern[i])
            {
                return false;
            }
        }
        return true;
    }
}