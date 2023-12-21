
var sol = new Solution();
sol.LeftRightDifference([10, 4, 8, 3]);


public class Solution
{
    public int[] LeftRightDifference(int[] nums)
    {
        int[] leftSum =LeftSum(nums);
        int[] rightSum = RightSum(nums);

        int[] results= new int[nums.Length];

        for(int i = 0; i < nums.Length; i++)        
            results[i] =Math.Abs(leftSum[i] - rightSum[i]);
        
        return results;
    }
    private int[] LeftSum(int[] nums)
    {
        int sum= 0;
        int[] leftSumArray = new int[nums.Length];

        for (int i = 0; i < nums.Length; i++)
        {
            leftSumArray[i] = sum;
            sum += nums[i];
        }
        return leftSumArray;
    }
    private int[] RightSum(int[] nums)
    {
        int sum = 0;
        int[] rightSumArray = new int[nums.Length];

        for (int i = nums.Length-1; i >= 0; i--)
        {
            rightSumArray[i] = sum;
            sum += nums[i];
        }
        return rightSumArray;
    }
}