
var sol = new Solution();


Console.WriteLine(sol.SpecialArray(nums: [0, 4, 3, 0, 4]));

Console.WriteLine(sol.SpecialArray(nums: [0, 0]));

Console.WriteLine(sol.SpecialArray(nums: [3,5]));


public class Solution
{
    public int SpecialArray(int[] nums)
    {
        var count = new int[nums.Length+1];

        foreach (var i in nums)
        {
            var index = Math.Min(nums.Length, i);
            count[index]++;
        }

        var rightSum = 0;

        for(int i = nums.Length; i > 0; i--)
        {
            rightSum += count[i];
            if (rightSum == i)
                return i;
        }


        return -1;
    }
} 