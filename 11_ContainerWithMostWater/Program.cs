//https://leetcode.com/problems/container-with-most-water/description/

var sol = new Solution();

var m = sol.MaxArea([1, 8, 6, 2, 5, 4, 8, 3, 7]);
Console.WriteLine(m);


Console.WriteLine(sol.MaxArea([1, 1]));

public class Solution
{
    public int MaxArea(int[] height)
    {
        int maxArea = 0;
        int pointerA = 0;
        int pointerB = height.Length - 1;

        while (pointerB>pointerA)
        {                
            int area = Math.Min(height[pointerA], height[pointerB]) * (pointerB - pointerA);
            maxArea = Math.Max(maxArea, area);

            if (height[pointerA] < height[pointerB])            
                pointerA++;            
            else            
                pointerB--;
        }
        return maxArea;
    }
}