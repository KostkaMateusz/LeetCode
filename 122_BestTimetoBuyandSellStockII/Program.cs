﻿// https://leetcode.com/problems/best-time-to-buy-and-sell-stock-ii/description/


public class Solution
{
    public int MaxProfit(int[] prices)
    {
        int profit = 0;

        for (int i = 1; i < prices.Length; i++)
        {
            if (prices[i] > prices[i - 1])
            {
                profit += prices[i] - prices[i - 1];
            }
        }
        return profit;
    }
}