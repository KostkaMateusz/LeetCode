// https://leetcode.com/problems/optimal-partition-of-string/description/

var sol = new Solution();


Console.WriteLine(sol.PartitionString("hdklqkcssgxlvehva"));


public class Solution
{
    public int PartitionString(ReadOnlySpan<char> s)
    {
        HashSet<char> group = [];

        int count = 1;

        foreach (var c in s)
        {
            if (group.Contains(c))
            {
                group.Clear();
                count++;
            }

            group.Add(c);
        }
        
        return count;
    }
}
