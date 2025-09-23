// https://leetcode.com/problems/check-if-array-is-sorted-and-rotated/

public class Solution
{
    public bool Check(int[] nums)
    {
        int lenght = nums.Length;
        int counter = 1;

        for (int i = 1; i < lenght * 2; i++)
        {
            if (nums[(i - 1) % lenght] <= nums[i % lenght])
            {
                counter++;
            }
            else
            {
                counter = 1;
            }

            if (counter == lenght)
            {
                return true;
            }
        }

        return lenght == 1;
    }
}