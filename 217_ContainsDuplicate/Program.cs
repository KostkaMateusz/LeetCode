


public class Solution
{
    public bool ContainsDuplicate(int[] nums)
    {
        // Create a HashSet to store unique integers
        var set = new HashSet<int>();

        // Iterate through each integer 'x' in the input array 'nums'
        foreach (int x in nums)
        {
            // Check if the HashSet already contains the current integer 'x'
            if (set.Contains(x))
            {
                // If 'x' is already in the HashSet, there is a duplicate
                // Return true indicating the presence of a duplicate
                return true;
            }

            // If 'x' is not in the HashSet, add it to the HashSet
            set.Add(x);
        }

        // If the loop completes without finding any duplicates, return false
        return false;
    }

}