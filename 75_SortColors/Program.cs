// https://leetcode.com/problems/sort-colors/description/

var sol = new Solution();

sol.SortColors([2, 0, 2, 1, 1, 0]);

public class Solution
{
    public void SortColors(int[] nums)
    {
        int[] colors = new int[3];

        foreach (var num in nums)
        {
            colors[num]++;
        }

        int index = 0;
        for (int i = 0; i < 3; i++)
        {
            while (colors[i] > 0)
            {
                colors[i]--;
                nums[index] = i;
                index++;
            }
        }

        return;
    }
}