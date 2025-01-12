// https://leetcode.com/problems/sort-characters-by-frequency/description/


using System.Text;

Console.WriteLine();

public class Solution
{
    public string FrequencySort(string s)
    {
        Dictionary<char, int> frequency = [];

        foreach (var character in s)
        {
            if (!frequency.TryAdd(character, 1))
            {
                frequency[character] += 1;
            }
        }

        StringBuilder result = new();

        var keysInOrder = frequency.OrderByDescending(x => x.Value).Select(x => x.Key);

        foreach (var key in keysInOrder)
        {
            result.Append(key, frequency[key]);
        }

        return result.ToString();
    }
}