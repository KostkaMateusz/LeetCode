// https://leetcode.com/problems/top-k-frequent-elements/

var sol = new Solution();

// sol.TopKFrequent(nums: [1, 1, 1, 2, 2, 3], k: 2);
sol.TopKFrequent(nums: [1], k: 1);

public class Solution
{
    public int[] TopKFrequent(int[] nums, int k)
    {
        Dictionary<int, int> dict = [];

        foreach (var num in nums)
        {
            if (!dict.TryAdd(num, 1))
            {
                dict[num]++;
            }
        }

        // Bucket Creation
        List<int>?[] bucket = new List<int>[nums.Length + 1];

        foreach (var kvp in dict)
        {
            if (bucket[kvp.Value] is null)
            {
                bucket[kvp.Value] = [kvp.Key];
            }
            else
            {
                bucket[kvp.Value]!.Add(kvp.Key);
            }
        }

        //Bucket select

        List<int> result = [];

        for (int i = bucket.Length - 1; i >= 0; i--)
        {
            if (bucket[i] is not null)
            {
                result.AddRange(bucket[i]!);
            }

            if (result.Count == k)
            {
                break;
            }
        }

        return result.ToArray();
    }
}


public class Solution1
{
    public int[] TopKFrequent(int[] nums, int k)
    {
        Dictionary<int, int> dict = [];


        foreach (var num in nums)
        {
            if (!dict.TryAdd(num, 1))
            {
                dict[num]++;
            }
        }

        return dict.OrderByDescending(kvp => kvp.Value)
            .Take(k)
            .Select(kvp => kvp.Key)
            .ToArray();
    }
}