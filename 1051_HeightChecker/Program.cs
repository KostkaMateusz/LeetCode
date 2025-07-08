// https://leetcode.com/problems/height-checker/description/

public class Solution
{
    public int HeightChecker(Span<int> heights)
    {
        int[] count = new int[101];
        foreach (var h in heights)
        {
            count[h]++;
        }

        int[] expected = new int[heights.Length];
        int index = 0;

        for (int h = 1; h <= 100; h++)
        {
            int c = count[h];
            for (int i = 0; i < c; i++)
            {
                expected[index] = h;
                index++;
            }
        }

        int res = 0;
        for (int i = 0; i < heights.Length; i++)
        {
            if (heights[i] != expected[i])
            {
                res++;
            }
        }

        return res;
    }
}