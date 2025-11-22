// https://leetcode.com/problems/majority-element/


public class Solution
{
    // Boyer-Moore Majority Voting Algorithm
    public int MajorityElement(int[] nums)
    {
        var count = 0;
        var currentMaj = -1;

        for (int i = 0; i < nums.Length; i++)
        {
            if (count == 0)
            {
                currentMaj = nums[i];
                count++;
            }
            else if (currentMaj == nums[i])
            {
                count++;
            }
            else
            {
                count--;
            }
        }

        return currentMaj;
    }
}


public class Solution1
{
    public int MajorityElement(int[] nums)
    {
        Dictionary<int, int> hashMap = [];

        for (int i = 0; i < nums.Length; i++)
        {
            if (hashMap.ContainsKey(nums[i]))
            {
                hashMap[nums[i]]++;
            }
            else
            {
                hashMap[nums[i]] = 1;
            }

            if (hashMap[nums[i]] > nums.Length / 2)
            {
                return nums[i];
            }
        }

        return hashMap
            .Where(kvp => kvp.Value == hashMap.Values.Max())
            .Select(kvp => kvp.Key)
            .First();
    }
}
