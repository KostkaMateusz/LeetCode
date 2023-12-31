//https://leetcode.com/problems/top-k-frequent-elements/description/


var sol = new Solution();

sol.TopKFrequent(nums: [1, 1, 1, 2, 2, 3], k: 2);

public class Solution
{
    public int[] TopKFrequent(int[] nums, int k)
    {
        // Use linq as alternative: 
        // return nums.GroupBy(num => num).OrderByDescending(num => num.Count()).Take(k).Select(c => c.Key).ToArray();

        // Step 1: Count the frequency of each element in the nums array
        var frequencyDictionary = new Dictionary<int, int>();
        foreach (var num in nums)
        {
            if (frequencyDictionary.ContainsKey(num) is false)
            {
                frequencyDictionary[num] = 0;
            }
            frequencyDictionary[num]++;
        }

        // Bucket sort
        // Step 2: Prepare a array of lists to store elements with the same frequency
        var buckets = new List<int>[nums.Length + 1];
        foreach (var num in frequencyDictionary.Keys)
        {
            var freq = frequencyDictionary[num];

            if (buckets[freq] is null)
            {
                buckets[freq] = new List<int>();
            }

            buckets[freq].Add(num);
        }

        // Step 3: Build the result array from buckets in descending order of frequency
        // the higher index in bucker array the higher freq
        var result = new List<int>();
        for (int i = buckets.Length - 1; result.Count < k; i--)
        {
            if (buckets[i] is not null)
            {
                result.AddRange(buckets[i]);
            }
        }

        return result.ToArray();
    }
}