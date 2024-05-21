// https://leetcode.com/problems/remove-element/


var sol = new Solution();
// sol.RemoveElement(nums: [0, 1, 2, 2, 3, 0, 4, 2], val: 2);
sol.RemoveElement(nums: [1], val: 1);


public class Solution
{
    public int RemoveElement(int[] nums, int val)
    {
        int k = 0;  // Counter for the new length

        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] != val)
            {
                nums[k] = nums[i];
                k++;
            }
        }

        return k;
    }
}
