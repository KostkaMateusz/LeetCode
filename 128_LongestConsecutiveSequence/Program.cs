//https://leetcode.com/problems/longest-consecutive-sequence/

var sol = new Solution();

sol.LongestConsecutive([100, 4, 200, 1, 3, 2]);
sol.LongestConsecutive([0, 3, 7, 2, 5, 8, 4, 6, 0, 1]);


public class Solution
{
    public int LongestConsecutive(int[] nums)
    {
        // Create a HashSet for faster lookups
        var hashMap = new HashSet<int>(nums);
        var longestConsecutive = 0;

        foreach (var num in nums)
        {
            // Value of potential previous element
            var prevElement = num - 1;

            // If the previous element exists in the HashSet, skip the current iteration
            if (hashMap.Contains(prevElement))
            {
                continue;
            }

            // If the previous element does not exist, check for consecutive elements
            var nextElement = num + 1;
            var currentLongest = 1;

            while (hashMap.Contains(nextElement))
            {
                currentLongest++;
                nextElement++;
            }

            longestConsecutive = Math.Max(longestConsecutive, currentLongest);
        }

        return longestConsecutive;
    }
}