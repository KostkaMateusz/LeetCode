// https://leetcode.com/problems/contains-duplicate/

var solution = new Solution();

var output = solution.ContainsDuplicate([1, 2, 3, 1]);

Console.WriteLine(output);

public class Solution
{
    public bool ContainsDuplicate(int[] nums)
    {
        HashSet<int> numsSet = [];

        foreach (var num in nums)
        {
            if (numsSet.Add(num) is false)
                return true;
        }

        return false;
    }
}