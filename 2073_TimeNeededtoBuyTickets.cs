// https://leetcode.com/problems/time-needed-to-buy-tickets/


public class Solution
{
    public int TimeRequiredToBuy(int[] tickets, int k)
    {
        var secondsSum = 0;

        for (int i = 0; i < tickets.Length; i++)
        {
            //when element is behind your index it will require one less ticket
            int time;
            if (i > k)
            {
                time = tickets[k] - 1;
            }
            else
            {
                time = tickets[k];
            }


            if (tickets[i] > time)
            {
                secondsSum += time;
            }
            else
            {
                secondsSum += tickets[i];
            }
        }


        return secondsSum;
    }
}
