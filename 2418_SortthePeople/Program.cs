// https://leetcode.com/problems/sort-the-people/description/

public class Solution
{
    public string[] SortPeople(string[] names, int[] heights)
    {

        int[] indices = Enumerable.Range(0, names.Length).ToArray();

        Array.Sort(indices, (a, b) => heights[b].CompareTo(heights[a]));

        string[] result = new string[names.Length];

        for (int i = 0; i < names.Length; i++)
        {
            result[i] = names[indices[i]];
        }
        return result;
    }
}


public class SolutionHashMap
{
    public string[] SortPeople(string[] names, int[] heights)
    {
        // since we now that heighs are distinct

        Dictionary<int, string> heightIndex = new();

        for (int i = 0; i < heights.Length; i++)
        {
            heightIndex.Add(heights[i], names[i]);
        }

        return heightIndex.OrderByDescending(kv => kv.Key).Select(kv => kv.Value).ToArray();


    }
}

