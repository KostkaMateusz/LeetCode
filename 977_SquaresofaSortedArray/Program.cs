//https://leetcode.com/problems/squares-of-a-sorted-array/

var sol = new Solution();

sol.SortedSquares([-4, -1, 0, 3, 10]);

public class Solution
{
    public int[] SortedSquares(int[] nums)
    {
        int leftPointer = 0;
        int rightPointer = nums.Length - 1;

        int currentPointer = nums.Length - 1;

        int[] sortedSquerasTable=new int[nums.Length];

        while (currentPointer !=-1)
        {
            int leftSquare = nums[leftPointer]* nums[leftPointer];
            int rightSquare = nums[rightPointer] * nums[rightPointer];

            if (leftSquare > rightSquare)
            {
                sortedSquerasTable[currentPointer]=leftSquare;
                leftPointer++;
            }
            else 
            {
                sortedSquerasTable[currentPointer] = rightSquare;
                rightPointer--;
            }

            currentPointer--;
        }
        return sortedSquerasTable;
    }
}