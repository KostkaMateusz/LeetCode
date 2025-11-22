// https://leetcode.com/problems/subarray-sum-equals-k/description/

var sol = new Solution();

// sol.SubarraySum(nums: [1, 2, 3], k: 3);
sol.SubarraySum(nums: [1, 1, 2, 2, 4], k: 4);


public class Solution
{
    public int SubarraySum(int[] nums, int k)
    {
        Dictionary<int, int> dict = []; // sum: counter
        dict.Add(0, 1);
        int counter = 0;
        int rollingSum = 0;

        for (int i = 0; i < nums.Length; i++)
        {
            rollingSum += nums[i];
            int prefix = rollingSum - k;
            counter += dict.GetValueOrDefault(prefix, 0);
            dict[rollingSum] = dict.GetValueOrDefault(rollingSum, 0) + 1;
        }


        return counter;
    }
}
