// https://leetcode.com/problems/set-mismatch/description/


public class Solution
{
    public int[] FindErrorNums(int[] nums)
    {
        int n = nums.Length;
        HashSet<int> numDict = [];

        int duplicated = -1;
        int missing = -1;

        foreach (var num in nums)
        {
            if (!numDict.Add(num))
            {
                duplicated = num;
            }
        }

        for (int i = 1; i < n + 1; i++)
        {
            if (!numDict.Contains(i))
            {
                missing = i;
            }
        }

        return [duplicated, missing];
    }
}
