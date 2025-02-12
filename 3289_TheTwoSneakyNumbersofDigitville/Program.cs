// https://leetcode.com/problems/the-two-sneaky-numbers-of-digitville/description/


public class Solution
{
    public int[] GetSneakyNumbers(int[] nums)
    {
        HashSet<int> visited = new();

        int[] duplciate = new int[2];
        int index = 0;

        foreach (var num in nums)
        {
            if (!visited.Add(num) )
            {
                duplciate[index] = num;
                index++;
            }

            if (index == 2)
            {
                break;
            }
        }

        return duplciate;
    }
}