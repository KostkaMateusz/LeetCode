// https://leetcode.com/problems/move-zeroes/

var sol = new Solution();

sol.MoveZeroes([0, 1, 0, 3, 12]);

public class Solution
{
    public void MoveZeroes(int[] nums)
    {
        int insertPos = 0;

        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] != 0)
            {
                nums[insertPos++] = nums[i];
            }
        }

        while (insertPos < nums.Length)
        {
            nums[insertPos++] = 0;
        }
    }
}
