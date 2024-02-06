// https://leetcode.com/problems/arranging-coins/description/

var sol = new Solution();

sol.ArrangeCoins(5);

public class Solution
{
    public int ArrangeCoins(int n)
    {
        var left = 0;
        var right = n;
        var result = 0;

        while (left <= right)
        {
            var mid = (left + right) / 2;
            //Gauss equation
            var coins = ((double)mid / 2) * (mid + 1);

            if (coins > n)
            {
                right = mid - 1;
            }
            else
            {
                left = mid + 1;
                result = Math.Max(mid, result);
            }
        }

        return result;
    }
}