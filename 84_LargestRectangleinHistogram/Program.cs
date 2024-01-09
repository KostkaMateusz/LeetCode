//https://leetcode.com/problems/largest-rectangle-in-histogram/

var sol = new Solution();
int max;

max = sol.LargestRectangleArea([2, 1, 5, 6, 2, 3]);
Console.WriteLine(max);

max = sol.LargestRectangleArea([2, 4]);
Console.WriteLine(max);

max = sol.LargestRectangleArea([0]);
Console.WriteLine(max);

max = sol.LargestRectangleArea([1]);
Console.WriteLine(max);



public class Solution
{
    public int LargestRectangleArea(int[] heights)
    {        
        int max = 0; // maximum rectangle area
        Stack<int> stack = new(); //keep track of indices of histogram bars

        // Iterate through the histogram bars, including an extra iteration to handle any remaining bars in the stack
        for (int i = 0; i <= heights.Length; i++)
        {
            // Set the current height or 0 if outside the array bounds
            int height = i < heights.Length ? heights[i] : 0;

            // While the stack is not empty and the current height is less than the height of the bar at the index on top of the stack
            while (stack.Count != 0 && heights[stack.Peek()] > height)
            {
                // Pop the index from the stack and get the corresponding height
                int currHeight = heights[stack.Pop()];

                // Get the index of the previous bar (or -1 if the stack is empty)
                int prevIndex = stack.Count == 0 ? -1 : stack.Peek();

                // Calculate the area of the rectangle formed by the popped bar
                // and update the maximum area if the calculated area is larger
                max = Math.Max(max, currHeight * (i - 1 - prevIndex));
            }

            // Push the current index onto the stack
            stack.Push(i);
        }

        // Return the maximum rectangle area
        return max;
    }
}


public class BruteForceSolution
{
    public int LargestRectangleArea(int[] heights)
    {
        int maxHeight=heights.Max();        
        int maxArea = -1; 
        int area = 0;
        
        for(int tryHight=0; tryHight <= maxHeight; tryHight++)
        {
            area = 0;
            for (int position = 0; position < heights.Length; position++)
            {                
                if (tryHight <= heights[position])
                {
                    area += tryHight;
                }
                else
                {                    
                    maxArea = Math.Max(maxArea,area);
                    area = 0;
                }
            }
            maxArea = Math.Max(maxArea, area);
        }
        return maxArea;
    }
}