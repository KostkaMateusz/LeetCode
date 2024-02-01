//https://leetcode.com/problems/move-zeroes/description/

var sol = new Solution();

sol.MoveZeroes([0, 1, 0, 3, 12]);

public class Solution
{
    public void MoveZeroes(int[] nums)
    {
        int leftPointer = 0;
        int rightPointer = 0;

        while (rightPointer < nums.Length)
        {
            if (nums[rightPointer] != 0)
            {
                int temp = nums[leftPointer];
                nums[leftPointer] = nums[rightPointer];
                nums[rightPointer] = temp;

                leftPointer++;
            }
            rightPointer++;
        }
    }
}