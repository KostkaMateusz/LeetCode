// https://leetcode.com/problems/best-time-to-buy-and-sell-stock/

var sol = new Solution();

Console.WriteLine(sol.MaxProfit([7,1,5,3,6,4]));
Console.WriteLine(sol.MaxProfit([7,6,4,3,1]));

public class Solution
{
    public int MaxProfit(int[] prices)
    {
        int left = 0;
        int right = 1;
        int maxProfit = 0;

        while (right<prices.Length)
        {
            if (prices[left] < prices[right])
            {
                int currentProfit = prices[right] - prices[left];
                maxProfit = Math.Max(maxProfit, currentProfit);
            }
            else
            {
                left = right;
            }

            right++;
        }
        return maxProfit;
    }
}