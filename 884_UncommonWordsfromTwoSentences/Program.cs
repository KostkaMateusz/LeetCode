// https://leetcode.com/problems/uncommon-words-from-two-sentences

public class Solution
{
    public string[] UncommonFromSentences(string s1, string s2)
    {
        Dictionary<string, int> count = new();

        foreach (var word in (s1 + " " + s2).Split(' '))
        {
            if (count.ContainsKey(word))
                count[word]++;
            else
                count[word] = 1;
        }

        List<string> output = new();
        foreach (var kvp in count)
        {
            if (kvp.Value == 1)
                output.Add(kvp.Key);
        }

        return output.ToArray();
    }
}