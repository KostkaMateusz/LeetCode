//https://leetcode.com/problems/daily-temperatures/

var sol = new Solution();
sol.DailyTemperatures([73, 74, 75, 71, 69, 72, 76, 73]);




public class Solution
{
    public int[] DailyTemperatures(int[] temperatures)
    {
        // Initialize an array to store the result (days until warmer temperature)
        var result = new int[temperatures.Length];

        // Initialize the result array with zeros
        Array.Fill(result, 0);

        // Create a stack to keep track of indices of temperatures
        var stack = new Stack<int>();

        // Iterate through the temperatures array
        for (int i = 0; i < temperatures.Length; i++)
        {
            // Get the current temperature
            var currentTemperature = temperatures[i];

            // Check if the stack is not empty and the current temperature is greater
            // than the temperature at the index at the top of the stack
            while (stack.Count != 0 && temperatures[stack.Peek()] < currentTemperature)
            {
                // Pop the index from the stack
                var prev = stack.Pop();

                // Update the result for the popped index with the difference in days
                result[prev] = i - prev;
            }

            // Push the current index onto the stack
            stack.Push(i);
        }

        // Return the result array
        return result;
    }
}