// https://leetcode.com/problems/average-waiting-time/

var sol = new Solution();

sol.AverageWaitingTime(customers: [[1, 2], [2, 5], [4, 3]]);


public class Solution
{
    public double AverageWaitingTime(int[][] customers)
    {
        int currentTime = 0;
        long totalWait = 0;

        foreach (int[] customer in customers)
        {
            int arrival = customer[0];
            int order = customer[1];

            if (currentTime > arrival)
            {
                totalWait += (currentTime - arrival);
            }
            else
            {
                currentTime = arrival;
            }

            totalWait += order;
            currentTime += order;

        }

        return (double)totalWait / customers.Length;
    }
}