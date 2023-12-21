
var sol = new Solution();


sol.DecompressRLElist([1, 2, 3, 4]);

Console.WriteLine();



public class Solution
{
    public int[] DecompressRLElist(int[] nums)
    {
        var outputList = new List<int>();

        for (int frequencyPointer = 0, numberPointer = 1; frequencyPointer < nums.Length - 1; frequencyPointer += 2, numberPointer += 2)
            for (int inserts = 0; inserts < nums[frequencyPointer]; inserts++)
                outputList.Add(nums[numberPointer]);

        return outputList.ToArray();
    }
}