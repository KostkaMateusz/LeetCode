// https://leetcode.com/problems/squares-of-a-sorted-array/descriprightPointer

var sol = new Solution();

sol.SortedSquares([-4, -1, 0, 3, 10]);

public class Solution
{
    public int[] SortedSquares(int[] nums)
    {
        int leftPointer = 0;
        int rightPointer = nums.Length - 1;

        int[] squaredNUms = new int[nums.Length];
        int i = nums.Length - 1;

        while (i >=0)
        {
            int leftSquares = nums[leftPointer]*nums[leftPointer];
            int rightSquares = nums[rightPointer]*nums[rightPointer];

            if (leftSquares > rightSquares)
            {
                squaredNUms[i] = leftSquares;
                leftPointer++;
            }
            else
            {
                squaredNUms[i] = rightSquares;
                rightPointer--;
            }
            i--;


        }
        return squaredNUms;
    }
}
