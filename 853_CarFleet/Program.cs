//https://leetcode.com/problems/car-fleet/

var sol = new Solution();
sol.CarFleet(12, [10, 8, 0, 5, 3], [2, 4, 1, 1, 3]);


public class Solution
{
    public int CarFleet(int target, int[] position, int[] speed)
    {
        // Create an array of tuples to store each car's position and speed
        var pairs = new (int position, int speed)[position.Length];

        // Populate the array with car positions and speeds
        for (int i = 0; i < position.Length; i++)
        {
            pairs[i] = (position[i], speed[i]);
        }

        // Use a stack to keep track of the time it takes for each car to reach the target
        Stack<double> stack = new();

        // Iterate through the cars in descending order of position
        foreach (var (p, s) in pairs.OrderByDescending(i => i.position))
        {
            // Calculate the time it takes for the current car to reach the target
            stack.Push((target - p) / (double)s);

            // If the car in front can catch up, remove the car in front from the stack
            if (stack.Count >= 2 && stack.Peek() <= stack.Skip(1).First())
            {
                stack.Pop();
            }
        }

        // The size of the stack represents the number of car fleets
        return stack.Count;
    }
}