// https://leetcode.com/problems/monotonic-array/


public class Solution
{
    public bool IsMonotonic(int[] nums)
    {
        bool isDescending = true;

        bool isAscending = true;

        int prevElement = nums[0];

        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] > prevElement)
            {
                isDescending = false;
            }
            else if (nums[i] < prevElement)
            {
                isAscending = false;
            }

            if (isDescending is false && isAscending is false)
            {
                break;
            }

            prevElement = nums[i];
        }

        return isDescending || isAscending;
    }
}
