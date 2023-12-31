//https://leetcode.com/problems/decompress-run-length-encoded-list/description/

var sol = new Solution();

sol.DecompressRLElist([1, 2, 3, 4]);

Console.WriteLine();


public class Solution
{
    // T: O(n) S: O(n)
    public int[] DecompressRLElist(int[] nums)
    {
        // Initialize a list to store the decompressed values
        var outputList = new List<int>();

        // Iterate through the input array in pairs (frequency, number)
        for (int frequencyPointer = 0, numberPointer = 1; frequencyPointer < nums.Length - 1; frequencyPointer += 2, numberPointer += 2)
        {
            // Repeat the next number according to its frequency
            for (int inserts = 0; inserts < nums[frequencyPointer]; inserts++)
            {
                // Add the number to the output list
                outputList.Add(nums[numberPointer]);
            }
        }        
        return outputList.ToArray();
    }
}