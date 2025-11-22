// https://leetcode.com/problems/maximum-product-difference-between-two-pairs/

var sol = new Solution();

// sol.MaxProductDifference([5, 6, 2, 7, 4]);
sol.MaxProductDifference([4, 2, 5, 9, 7, 4, 8]);


public class Solution
{
    public int MaxProductDifference(int[] nums)
    {
        var max = 0;
        var secondMax = 0;
        var min = int.MaxValue;
        var secondMin = int.MaxValue;

        foreach (var currentNumber in nums)
        {
            if (currentNumber > max)
            {
                secondMax = max;
                max = currentNumber;
            }
            else if (currentNumber > secondMax)
            {
                secondMax = currentNumber;
            }

            if (currentNumber < min)
            {
                secondMin = min;
                min = currentNumber;
            }
            else if (currentNumber < secondMin)
            {
                secondMin = currentNumber;
            }
        }

        return (max * secondMax) - (min * secondMin);
    }
}
