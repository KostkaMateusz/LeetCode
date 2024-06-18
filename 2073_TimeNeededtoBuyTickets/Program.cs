


var sol = new Solution();

sol.TimeRequiredToBuy(tickets : [2, 3, 2], k : 2);

sol.TimeRequiredToBuy(tickets : [5, 1, 1, 1], k : 0);


public class Solution
{
    public int TimeRequiredToBuy(int[] tickets, int k)
    {        
        int secounds = 0;

        for(int i = 0; i < tickets.Length; i++)
        {
            int target = (i > k) ? (tickets[k] - 1) : tickets[k];

            secounds += Math.Min(tickets[i], target);
        }

        return secounds;
    }
}