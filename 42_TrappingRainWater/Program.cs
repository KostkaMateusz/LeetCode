//https://leetcode.com/problems/trapping-rain-water/description/

var sol = new Solution();
int results;
results=sol.Trap([0, 1, 0, 2, 1, 0, 1, 3, 2, 1, 2, 1]);
Console.WriteLine(results);

public class Solution
{
    public int Trap(int[] height)
    {
        int[] rightMaxArray = new int[height.Length];

        int rightMax = -1;

        // Calculate the maximum height to the right for each element
        for (int i = height.Length - 1; i > 0; i--)
        {
            rightMax = Math.Max(rightMax, height[i]);
            rightMaxArray[i] = rightMax;
        }

        int leftMax = -1;
        int trappedWater = 0;

        for (int i = 0; i < height.Length; i++)
        {
            // Calculate the maximum height to the left of the current element
            leftMax = Math.Max(leftMax, height[i]);

            // Calculate the difference between the minimum of leftMax and rightMaxArray[i] and the current element's height
            int difference = Math.Min(leftMax, rightMaxArray[i]) - height[i];

            // If there is trapped water (difference > 0), add it to the total trapped water
            if (difference > 0)
                trappedWater += difference;
        }
        return trappedWater;
    }
}