// https://leetcode.com/problems/sort-array-by-increasing-frequency/description/


public class Solution
{
    public int[] FrequencySort(int[] nums)
    {
        Dictionary<int, int> counter = [];

        foreach (int num in nums)
        {
            if (!counter.TryAdd(num, 1))
            {
                counter[num] += 1;
            }
        }

        Array.Sort(nums, (a, b) =>
        {
            var afreq = counter[a];
            var bfreq = counter[b];

            if (afreq > bfreq)
            {
                return 1;
            }
            else if (afreq < bfreq)
            {
                return -1;
            }
            else
            {
                if (a > b)
                    return -1;
                else
                    return 1;
            }

        });

        return nums;
    }
}
