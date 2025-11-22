// https://leetcode.com/problems/divide-array-into-arrays-with-max-difference/description/

public class Solution
{
    public int[][] DivideArray(int[] nums, int k)
    {
        Array.Sort(nums);

        int[][] result = new int[nums.Length / 3][];

        for (int i = 0, buckerNumber = 0; i < nums.Length; i += 3, buckerNumber++)
        {
            if (nums[i + 2] - nums[i] > k)
            {
                return new int[][] { };
            }

            result[buckerNumber] = new int[3];

            result[buckerNumber][0] = nums[i];
            result[buckerNumber][1] = nums[i + 1];
            result[buckerNumber][2] = nums[i + 2];
        }
        return result;
    }
}
