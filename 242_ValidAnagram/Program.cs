//https://leetcode.com/problems/valid-anagram/



var sol = new Solution();

var results=sol.IsAnagram(s : "anagram", t : "aagaram");
Console.WriteLine(results);

public class Solution
{
    public bool IsAnagram(string s, string t)
    {
        // If the lengths of the two strings are different, they cannot be anagrams
        if (s.Length != t.Length) return false;

        // If the strings are identical, they are considered anagrams
        if (s == t) return true;

        // Create dictionaries to store character frequencies for each string
        var sDictionary = new Dictionary<char, int>();
        var tDictionary = new Dictionary<char, int>();

        // Populate dictionaries with character frequencies for string s and t
        for (int i = 0; i < s.Length; i++)
        {
            sDictionary[s[i]] = 1 + (sDictionary.ContainsKey(s[i]) ? sDictionary[s[i]] : 0);

            tDictionary[t[i]] = 1 + (tDictionary.ContainsKey(t[i]) ? tDictionary[t[i]] : 0);
        }

        // Compare character frequencies between the two dictionaries
        foreach (char c in sDictionary.Keys)
        {         
            int tCount = tDictionary.ContainsKey(c) ? tDictionary[c] : 0;
         
            if (sDictionary[c] != tCount) return false;
        }

        return true;
    }

}