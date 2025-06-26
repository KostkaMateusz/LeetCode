// https://leetcode.com/problems/special-array-i/description/

public class Solution
{
    public bool IsArraySpecial(int[] nums)
    {
        bool shouldBe0 = nums[0] % 2 == 0;

        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] % 2 == 0 == shouldBe0)
            {
                shouldBe0 = !shouldBe0;
            }
            else
            {
                return false;
            }
        }
        return true;
    }

}