//https://leetcode.com/problems/kids-with-the-greatest-number-of-candies/description/

public class Solution
{
    public IList<bool> KidsWithCandies(int[] candies, int extraCandies)
    {
        int maxCandies=candies.Max(x => x);
        bool[] willHaveMax=new bool[candies.Length];

        for (int i = 0; i < candies.Length; i++)
        {
            if (candies[i]+extraCandies>= maxCandies)
            {
                willHaveMax[i]=true;
            }
            else
            {
                willHaveMax[i]=false;
            }
        }

        return willHaveMax;
    }
}