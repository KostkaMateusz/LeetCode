// https://leetcode.com/problems/two-sum/

int[] nums = [2, 7, 11, 15];

var target = 9;


public class Solution
{
    public int[] TwoSum(int[] nums, int target)
    {
        Dictionary<int, int> dict = new();

        for (int i = 0; i < nums.Length; i++)
        {
            var searchFor = target - nums[i];

            if (dict.TryGetValue(searchFor, out int res) is false)
                dict[nums[i]] = i;
            else
            {
                return [res, i];
            }
        }

        return [];
    }
}
