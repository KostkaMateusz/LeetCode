//https://leetcode.com/problems/sum-of-values-at-indices-with-k-set-bits/description/

var sol = new Solution();

Console.WriteLine(sol.SumIndicesWithKSetBits([5, 10, 1, 5, 2], 1));

public class Solution
{
    public int SumIndicesWithKSetBits(IList<int> nums, int k)
    {
        var sum = 0;

        for (int i=0; i < nums.Count;  i++)
        {
            var binaryRepresentation=Convert.ToString(i, 2);
            var countOnes=binaryRepresentation.Count(x=>x=='1');

            if (countOnes == k)
            {
                sum += nums[i];
            }
        }

        return sum;
    }
}