//https://leetcode.com/problems/binary-search/

var sol = new Solution();
int index;

index = sol.SearchInsert(nums : [1, 3, 5, 6], target : 5);
Console.WriteLine(index);

index = sol.SearchInsert(nums: [1, 3, 5, 6], target : 2);
Console.WriteLine(index);


index = sol.SearchInsert(nums : [1, 3, 5, 6], target : 7);
Console.WriteLine(index);

public class Solution
{
    public int SearchInsert(int[] nums, int target)
    {
        int low = 0;
        int high = nums.Length - 1;
        
        while (low <= high)
        {
            int mid = low + (high - low) / 2;

            if (target == nums[mid])
                return mid;
            if (target > nums[mid])
                low = mid + 1;           
            else
                high = mid - 1;           
        }
        return low;
    }
}