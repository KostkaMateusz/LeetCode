// https://leetcode.com/problems/average-waiting-time/

public class Solution
{
    public double AverageWaitingTime(int[][] customers)
    {
        int currentTime = 1;
        int[] customerWaitTaime = new int[customers.Length];

        for (int i = 0; i < customers.Length; i++)
        {
            int[] customer = customers[i];

            if (customer[0] >= currentTime)
            {
                currentTime = customer[0];
            
            
                currentTime += customer[1];


            }


        }

    }
}