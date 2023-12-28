


var sol = new Solution();

sol.DifferenceOfSum([1, 15, 6, 3]);


public class Solution
{
    public int DifferenceOfSum(int[] nums)
    {        
        return ElementSum(nums) - DigitSum(nums);
    }

    private int ElementSum(int[] nums)
    {
        int sum = 0;        
        for (int i = 0; i < nums.Length; i++)
            sum+= nums[i];
    
        return sum;
    }

    private int DigitSum(int[] nums)
    {
        int sum = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            var currentElement = nums[i];
            while (currentElement != 0)
            {                
                sum += currentElement % 10;
                currentElement /= 10;
            }
        }
        return sum;
    }

}