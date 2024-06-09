
var sol = new Solution();

int output;

output=sol.MaxProductDifference([4, 2, 5, 9, 7, 4, 8]);

Console.WriteLine(output);

public class Solution
{
    public int MaxProductDifference(int[] nums)
    {
        int max = Int32.MinValue;
        int max2 = Int32.MinValue;

        int min = Int32.MaxValue;
        int min2 = Int32.MaxValue;

        for (int i =0; i<nums.Length; i++)
        {
            var current=nums[i];

            if (current > max)
            {
                max2 = max;
                max = current;
            }
            else if(current > max2)
            {
                max2 = current;
            }

            if (current < min)
            {
                min2 = min;
                min = current;
            }
            else if(current < min2)
            {
                min2= current;
            }
        }
        return (max * max2) - (min * min2);
    }
}