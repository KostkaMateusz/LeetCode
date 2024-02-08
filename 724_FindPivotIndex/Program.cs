// https://leetcode.com/problems/find-pivot-index/description/

var sol = new Solution();
var output = 0;

output = sol.PivotIndex([1, 7, 3, 6, 5, 6]);
Console.WriteLine(output);

output = sol.PivotIndex([1, 2, 3]);
Console.WriteLine(output);

output = sol.PivotIndex([2, 1, -1]);
Console.WriteLine(output);


public class Solution
{
    public int PivotIndex(int[] nums)
    {
        var rightSum = nums.Sum();

        var leftSum = 0;

        for (var i = 0; i < nums.Length; i++)
        {
            rightSum -= nums[i];

            if (leftSum == rightSum)
                return i;

            leftSum += nums[i];
        }
        return -1;
    }
}