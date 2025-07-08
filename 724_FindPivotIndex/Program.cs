// https://leetcode.com/problems/find-pivot-index/description/

int[] nums = [1, 7, 3, 6, 5, 6];

var sol = new Solution();

var index = sol.PivotIndex(nums);

Console.WriteLine();
public class Solution
{
    public int PivotIndex(int[] nums)
    {
        int rightSum = nums.Sum();
        int leftSum = 0;

        for (int i = 0; i < nums.Length; i++)
        {
            leftSum += nums[i];

            if (leftSum == rightSum)
            {
                return i;
            }

            rightSum -= nums[i];
        }

        return -1;
    }
}