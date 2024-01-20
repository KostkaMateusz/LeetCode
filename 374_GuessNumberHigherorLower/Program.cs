//https://leetcode.com/problems/guess-number-higher-or-lower/description/


/** 
 * Forward declaration of guess API.
 * @param  num   your guess
 * @return 	     -1 if num is higher than the picked number
 *			      1 if num is lower than the picked number
 *               otherwise return 0
 * int guess(int num);
 */


var sol = new Solution();

sol.GuessNumber(35);


public class Solution : GuessGame
{
    public int GuessNumber(int n)
    {
        int low = 1;
        int high = n;

        while (low <= high)
        {
            int mid = low + (high - low) / 2;
            int result = guess(mid);
                        
            if (result == -1)
                high = mid - 1;
            else if(result ==1)
                low = mid + 1;
            else
                return mid;
        }
        return -1;
    }
}


public class GuessGame
{
    private int pick = 20;

    public int guess(int num)
    {
        if (num > pick)
            return -1;
        else if (num < pick)
            return 1;
        else
            return 0;
    }
}