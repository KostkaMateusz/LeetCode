// https://leetcode.com/problems/number-of-zero-filled-subarrays/description/

var sol = new Solution();

sol.ZeroFilledSubarray([0, 0, 0, 2, 0, 0]);


public sealed class Solution
{
    public long ZeroFilledSubarray(ReadOnlySpan<int> nums)
    {
        long result = 0;
        int currentCount = 0;

        foreach (var t in nums)
        {
            if (t == 0)
            {
                currentCount++;
            }
            else
            {
                currentCount = 0;
            }

            result += currentCount;
        }

        return result;
    }
}


public sealed class Solution1
{
    public long ZeroFilledSubarray(ReadOnlySpan<int> nums)
    {
        long result = 0;
        int currentCount = 0;

        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] == 0)
            {
                currentCount++;
            }
            else if (nums[i] != 0 && currentCount != 0)
            {
                result += Count(currentCount);
                currentCount = 0;
            }
        }

        result += Count(currentCount);

        return result;
    }

    private static long Count(long number)
    {
        return number * (number + 1) / 2;
    }
}
