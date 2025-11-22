// https://leetcode.com/problems/sort-array-by-parity/description/


public class Solution
{
    public int[] SortArrayByParity(int[] nums)
    {
        int[] output = new int[nums.Length];


        int leftPointer = 0;
        int rightPointer = nums.Length-1;


        foreach (var number in nums)
        {
            if (number % 2 == 0)
            {
                output[leftPointer] = number;
                leftPointer++;
            }
            else
            {
                output[rightPointer] = number;
                rightPointer--;
            }
        }


        return output;
    }
}
