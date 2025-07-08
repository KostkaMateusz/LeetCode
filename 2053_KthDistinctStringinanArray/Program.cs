// https://leetcode.com/problems/kth-distinct-string-in-an-array/


var sol = new Solution();

sol.KthDistinct(arr: ["d", "b", "c", "b", "c", "a"], k: 2);

public class Solution
{

    public string KthDistinct(string[] arr, int k)
    {
        OrderedDictionary<string, int> dict = new(); // key, count

        for (int i = 0; i < arr.Length; i++)
        {
            string strAt = arr[i];

            if (!dict.TryAdd(strAt, 1))
            {
                dict[strAt] += 1;
            }
        }

        int kIndex = 0;

        foreach (var (key, value) in dict)
        {
            if (value == 1)
            {
                kIndex++;
            }

            if (kIndex == k)
            {
                return key;
            }

        }

        return "";

    }
}