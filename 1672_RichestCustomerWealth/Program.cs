//https://leetcode.com/problems/richest-customer-wealth/description/

var sol = new Solution();
public class Solution
{
    public int MaximumWealth(int[][] accounts)
    {
        var clientsMoney = new int[accounts.Length];

        for (int i = 0; i < accounts.Length; i++)
        {
            clientsMoney[i] = 0;
            for (int j = 0; j < accounts[i].Length; j++)
            {
                clientsMoney[i] += accounts[i][j];
            }
        }

        return clientsMoney.Max();
    }
}