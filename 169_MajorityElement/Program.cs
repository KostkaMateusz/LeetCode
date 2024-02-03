// https://leetcode.com/problems/majority-element/description/

var sol = new Solution();

int result;

result = sol.MajorityElement([3, 2, 3]);
Console.WriteLine(result);

result = sol.MajorityElement([2, 2, 1, 1, 1, 2, 2]);
Console.WriteLine(result);
public class Solution
{
    // Boyer Moore Algorithm
    public int MajorityElement(int[] nums)
    {
        int result = 0;
        int count = 0;

        foreach (var num in nums)
        {
            if (count == 0)
                result = num;

            if (num == result)
                count++;
            else
                count--;
        }
        return result;
    }
}

public class Solution2
{
    public int MajorityElement(int[] nums)
    {
        var majority = nums.Length / 2;

        Dictionary<int, int> counter = [];

        foreach (var num in nums)
        {
            if (!counter.TryAdd(num, 0)) counter[num]++;

            if (counter[num] > majority)
                return num;
        }

        return counter.MaxBy(kvp => kvp.Value).Key;
    }
}