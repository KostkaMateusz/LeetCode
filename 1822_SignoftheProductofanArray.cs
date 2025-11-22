// https://leetcode.com/problems/sign-of-the-product-of-an-array/

Console.WriteLine();

public class Solution
{
    public int ArraySign(Span<int> nums)
    {
        int sign = 1;

        foreach (var num in nums)
        {
            if (num == 0)
            {
                return 0;
            }
            else if (num < 0)
            {
                sign *= -1;
            }
        }

        return sign;
    }
}
