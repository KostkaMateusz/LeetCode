// https://leetcode.com/problems/special-array-with-x-elements-greater-than-or-equal-x/


public class Solution
{
    public int SpecialArray(int[] nums)
    {
        // if solution exist it must e from 1 ,n range where n is lenght of array
        // initialize array for element counting
        int[] count = new int[nums.Length + 1]; // [1,n]
        foreach (var n in nums)
        {
            var index = n < nums.Length ? n : nums.Length;
            count[index]++;
        }

        //now we're counting from right to left how much elements are greater or equal

        int rightSum = 0;
        for (int i = nums.Length; i >= 0; i--)
        {
            rightSum += count[i];
            if (rightSum == i)
            {
                return i;
            }
        }

        return -1;
    }
}
