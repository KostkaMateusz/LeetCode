// https://leetcode.com/problems/group-anagrams/description/

string[] strs = ["eat", "tea", "tan", "ate", "nat", "bat"];

var sol = new Solution();

sol.GroupAnagrams(strs);

Console.WriteLine();

public class Solution
{
    public IList<IList<string>> GroupAnagrams(string[] strs)
    {
        Dictionary<string, IList<string>> hashMap = [];

        foreach (var str in strs)
        {
            char[] hash = new char[26];

            foreach (var c in str)
            {
                hash[c - 'a']++;
            }

            string hashString = new string(hash);

            if (hashMap.TryGetValue(hashString, out var value))
            {
                value.Add(str);
            }
            else
            {
                hashMap.Add(hashString, [str]);
            }
        }

        return hashMap.Values.ToList();
    }
}
