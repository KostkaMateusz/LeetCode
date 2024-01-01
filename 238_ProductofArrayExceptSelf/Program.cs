//https://leetcode.com/problems/product-of-array-except-self/description/

var sol = new Solution();
sol.ProductExceptSelf([1, 2, 3, 4]);

public class Solution
{
    //T: O(n) S:(n)
    public int[] ProductExceptSelf(int[] nums)
    {
        var outPut = new int[nums.Length];

        var preFix = 1;
        // Loop through the array to calculate the product of elements before the current index
        for (int i = 0; i < outPut.Length; i++)
        {
            outPut[i] = preFix;
            preFix *= nums[i];
        }

        var postFix = 1;
        // Loop through the array in reverse to calculate the product of elements after the current index
        for (int i = outPut.Length - 1; i >= 0; i--)
        {
            outPut[i] *= postFix;
            postFix *= nums[i];
        }

        return outPut;
    }
}