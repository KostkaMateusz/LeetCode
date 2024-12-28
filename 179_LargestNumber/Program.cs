// https://leetcode.com/problems/largest-number/description/

var sol = new Solution();

sol.LargestNumber([3, 30, 34, 5, 9]);


public class Solution
{
    public string LargestNumber(ReadOnlySpan<int> nums)
    {
        string[] numsStr = new string[nums.Length];

        for (int i = 0; i < nums.Length; i++)
        {
            numsStr[i] = nums[i].ToString();
        }

        Array.Sort(numsStr, Compare);

        return numsStr![0][0] == '0' ? "0" : string.Concat(numsStr!);
    }

    private int Compare(string num1, string num2)
    {
        var option1 = string.Concat(num1, num2);
        var option2 = string.Concat(num2, num1);

        if (ulong.Parse(option1) > ulong.Parse(option2))
            return -1;
        if (ulong.Parse(option1) < ulong.Parse(option2))
            return 1;

        return 0;
    }
}