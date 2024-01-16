//https://leetcode.com/problems/binary-search/

var sol = new Solution();
int index;

index = sol.Search(nums: [-1, 0, 3, 5, 9, 12], target: 9);
Console.WriteLine(index);

index = sol.Search(nums: [-1, 0, 3, 5, 9, 12], target: 2);
Console.WriteLine(index);


public class Solution
{
    public int Search(int[] nums, int target)
    {
        int low = 0;
        int high = nums.Length - 1;

        while (low <= high)
        {
            int mid = low + (high - low) / 2;

            if (target > nums[mid])
                low = mid + 1;
            else if (target < nums[mid])
                high = mid - 1;
            else
                return mid;
        }
        return -1;
    }
}