public class Solution
{
    public int[] SmallerNumbersThanCurrent(int[] nums)
    {
        Dictionary<int, int> counter = [];

        foreach (var num in nums)
        {
            if (!counter.TryAdd(num, 1))
            {
                counter[num] += 1;
            }
        }

        int[] output = new int[nums.Length];

        for (int i = 0; i < nums.Length; i++)
        {

            var num = nums[i];
            int count = 0;
            foreach (var keyvalue in counter)
            {
                if (keyvalue.Key < num)
                {
                    count += keyvalue.Value;
                }
            }

            output[i] = count;
        }
        return output;
    }
}