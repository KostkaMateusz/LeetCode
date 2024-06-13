


var sol = new Solution();

sol.FindErrorNums([1, 2, 2, 4]);

public class Solution
{
    public int[] FindErrorNums(int[] nums)
    {
        var hashMap=new HashSet<int>();

        var n=nums.Length;

        int doubled=0;
        int missing=0;

        for (int i=0; i<n; i++)
        {
            if (hashMap.Contains(nums[i]))
            {
                doubled = nums[i];              
            }      
            
            hashMap.Add(nums[i]);            
        }

        for(int i = 1; i <= n; i++)
        {
            if (!hashMap.Contains(i))
            {
                missing = i;
            }
        }

        return new int[] { doubled, missing };
    }
}