//https://leetcode.com/problems/group-anagrams/submissions/1132809041/

var sol = new Solution();

sol.GroupAnagrams(["eat", "tea", "tan", "ate", "nat", "bat"]);

sol.GroupAnagrams([""]);

sol.GroupAnagrams(["a"]);


public class Solution
{
    //T: O(n*m) where n is the number of words and m is the length of the longest word
    //S: O(n)
    public IList<IList<string>> GroupAnagrams(string[] strs)
    {
        // Initialize a dictionary to store anagrams grouped by their character counts.
        var HashMap = new Dictionary<string, IList<string>>();
                
        foreach (string word in strs)
        {
            // Initialize an array to represent the count of each character in the word.
            var hash = new char[26];        
            foreach (char ch in word)
            {
                hash[ch - 'a']++;
            }

            var key = new string(hash);
            if (HashMap.ContainsKey(key) is false)
            {
                HashMap[key] = new List<string>();
            }

            HashMap[key].Add(word);
        }
        return HashMap.Values.ToList();
    }
}