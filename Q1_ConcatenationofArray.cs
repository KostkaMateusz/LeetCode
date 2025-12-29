
var sol=new Solution();

sol.GetConcatenation([1,2,1]);

public class Solution
{
    public int[] GetConcatenation(int[] nums)
    {
        int[] concatenatedArray = new int[nums.Length * 2];

        for (int i = 0; i < nums.Length; i++)
        {
            concatenatedArray[i] = nums[i];
            concatenatedArray[nums.Length + i] = nums[i];
        }

        return concatenatedArray;

    }
}