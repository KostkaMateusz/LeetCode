//https://leetcode.com/problems/3sum/


var sol = new Solution();

sol.ThreeSum([-1, 0, 1, 2, -1, -4]);




public class Solution
{
    public IList<IList<int>> ThreeSum(int[] nums)
    {
        List<IList<int>> res = [];
        
        // Sort the input array in ascending order
        Array.Sort(nums);

        for (int i = 0; i < nums.Length; i++)
        {
            // Skip duplicate elements to avoid duplicate triplets
            if (i > 0 && nums[i] == nums[i - 1])
                continue;
          
            int l = i + 1;
            int r = nums.Length - 1;
         
            while (l < r)
            {
                // Calculate the sum of the current triplet
                int threeSum = nums[i] + nums[l] + nums[r];

                // If the sum is greater than zero, decrement the right pointer
                if (threeSum > 0)
                {
                    r--;
                }
                // If the sum is less than zero, increment the left pointer
                else if (threeSum < 0)
                {
                    l++;
                }
                // If the sum is zero, add the triplet to the result list
                else
                {
                    res.Add(new List<int> { nums[i], nums[l], nums[r] });

                    // Increment the left pointer and skip duplicate elements
                    l++;
                    while (l < r && nums[l] == nums[l - 1])
                    {
                        l++;
                    }
                }
            }
        }
        return res;
    }
}