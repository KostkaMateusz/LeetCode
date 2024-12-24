// https://leetcode.com/problems/product-of-array-except-self/description/

var sol = new Solution();

sol.ProductExceptSelf([1, 2, 3, 4]);

public class Solution
{
    public int[] ProductExceptSelf(int[] nums)
    {
        int[] result = new int[nums.Length];

        result[0] = 1;

        for (int i = 1; i < nums.Length; i++)
        {
            result[i] = nums[i - 1] * result[i - 1];
        }

        int sufix = 1;
        for (int i = nums.Length - 2; i >= 0; i--)
        {
            sufix = nums[i + 1] * sufix;

            result[i] = result[i] * sufix;
        }

        return result;
    }
}

public class SolutionBeta
{
    public int[] ProductExceptSelf(int[] nums)
    {
        int[] prefix = new int[nums.Length];
        int[] sufix = new int[nums.Length];
        int[] result = new int[nums.Length];

        Array.Fill(prefix, 1); // basically loop over array and assign value
        Array.Fill(sufix, 1);


        for (int i = 1; i < nums.Length; i++)
        {
            prefix[i] = nums[i - 1] * prefix[i - 1];
        }

        for (int i = nums.Length - 2; i >= 0; i--)
        {
            sufix[i] = nums[i + 1] * sufix[i + 1];
        }

        for (int i = 0; i < nums.Length; i++)
        {
            result[i] = prefix[i] * sufix[i];
        }

        //after 5 loops

        return result;
    }
}