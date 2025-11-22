// https://leetcode.com/problems/find-common-characters/

public class Solution
{
    public IList<string> CommonChars(string[] words)
    {

        List<Dictionary<char, int>> hashes = [];


        foreach (var word in words)
        {
            Dictionary<char, int> counter = [];
            foreach (var c in word)
            {
                if (!counter.TryAdd(c, 1))
                {
                    counter[c]++;
                }
            }
            hashes.Add(counter);
        }


        IList<string> commonChars = [];


        foreach (var kvp in hashes[0])
        {
            char ch = kvp.Key;
            int minCount = kvp.Value;

            for (int i = 1; i < hashes.Count; i++)
            {
                if (hashes[i].TryGetValue(ch, out int count))
                {
                    minCount = Math.Min(minCount, count);
                }
                else
                {
                    minCount = 0;
                    break;
                }
            }

            for (int i = 0; i < minCount; i++)
            {
                commonChars.Add(ch.ToString());
            }
        }

        return commonChars;
    }
}
