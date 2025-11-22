// https://leetcode.com/problems/find-lucky-integer-in-an-array/

public class Solution
{
    public int FindLucky(int[] arr)
    {
        int[] counts = new int[501];

        foreach (int numb in arr)
        {
            counts[numb] += 1;
        }

        for (int i = counts.Length - 1; i > 0; i--)
        {
            if (i == counts[i])
            {
                return i;
            }
        }

        return -1;
    }
}
