//https://leetcode.com/problems/two-sum/description/

var sol = new Solution();

sol.TwoSum([2, 7, 11, 15],9);

public class Solution
{
    // T:O(n) S:O(n)    
    public int[] TwoSum(int[] nums, int target)
    {        
        var valueDictionary = new Dictionary<int, int>();
     
        for (int i = 0; i < nums.Length; i++)
        {
            // Calculate the difference between the target and the current array element
            var diff = target - nums[i];
            
            // Check if diff is in Dictionary
            if (valueDictionary.ContainsKey(diff))
            {
                // if yes Return the indices of the two numbers that add up to the target
                return [valueDictionary[diff], i];
            }
            else
            {
                // if no Store the current array element and its index in the dictionary
                valueDictionary[nums[i]] = i;
            }
        }
        // If no such pair is found, return an empty array
        return [];
    }
}