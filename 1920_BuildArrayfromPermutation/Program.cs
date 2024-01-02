//https://leetcode.com/problems/build-array-from-permutation/description/

var sol = new Solution();

var arr = new int[] { 0, 2, 1, 5, 3, 4 };

sol.BuildArray(arr);

public class Solution
{

    public int[] BuildArray(int[] nums)
    {
        for (int i = 0; i < nums.Length; i++)
        {
            // add secondary values onto original values as multples of the length of the array
            // modulus means original value while integer division gives the result values
            nums[i] += (nums[nums[i]] % nums.Length) * nums.Length;
        }
        Console.WriteLine(string.Join(',', nums));
        for (int i = 0; i < nums.Length; i++)
        {
            nums[i] = nums[i] / nums.Length;
        }
        Console.WriteLine(string.Join(',', nums));
        return nums;
    }

    public int[] BuildArray2(int[] nums)
    {
        return nums.Select(x => nums[x]).ToArray();
    }
}