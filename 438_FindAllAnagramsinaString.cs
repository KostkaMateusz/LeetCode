// https://leetcode.com/problems/find-all-anagrams-in-a-string/description/

var sol = new Solution();

sol.FindAnagrams(s: "cbaebabacd", p: "abc");


public class Solution
{
    public IList<int> FindAnagrams(string s, string p)
    {
        Dictionary<char, int> pDict = [];
        Dictionary<char, int> sDict = [];

        foreach (var ch in p)
        {
            if (!pDict.TryAdd(ch, 1))
            {
                pDict[ch]++;
            }
            else
            {
                sDict[ch] = 0;
            }
        }

        List<int> output = [];
        Queue<int> q = new Queue<int>();

        for (int i = 0; i < s.Length; i++)
        {
            if (sDict.ContainsKey(s[i]))
            {
                sDict[s[i]]++;
            }

            q.Enqueue(i);

            if (q.Count == p.Length)
            {
                //check if we have anagram
                bool anagram = true;
                foreach (var kvp in pDict)
                {
                    if (sDict[kvp.Key] != kvp.Value)
                    {
                        anagram = false;
                        break;
                    }
                }

                if (anagram)
                {
                    output.Add(q.Peek());
                }

                var dequeuedIndex = q.Dequeue();
                var dequeued = s[dequeuedIndex];
                if (sDict.ContainsKey(dequeued))
                {
                    sDict[dequeued]--;
                }
            }
        }

        return output;
    }
}
