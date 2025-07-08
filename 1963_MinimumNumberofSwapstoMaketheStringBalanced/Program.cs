// https://leetcode.com/problems/minimum-number-of-swaps-to-make-the-string-balanced/description/

var solution = new Solution();


public class Solution
{
    public int MinSwaps(string s)
    {
        int maxSwapNumber = 0;
        int swapNumber = 0;


        foreach (var character in s.AsSpan())
        {
            if (character == '[')
            {
                swapNumber--;
            }
            else
            {
                swapNumber++;
            }
            maxSwapNumber = Math.Max(maxSwapNumber, swapNumber);
        }

        return (maxSwapNumber + 1) / 2;
    }
}