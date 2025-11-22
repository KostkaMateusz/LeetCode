// https://leetcode.com/problems/replace-elements-with-greatest-element-on-right-side/


int[] arr = [17, 18, 5, 4, 6, 1];

var sol = new Solution();

var output = sol.ReplaceElements(arr);
Console.WriteLine();

public class Solution
{
    public int[] ReplaceElements(int[] arr)
    {
        int rightMaximum = -1;

        for (int i = arr.Length - 1; i >= 0; i--)
        {
            var newMax = Math.Max(arr[i], rightMaximum);

            arr[i] = rightMaximum;

            rightMaximum = newMax;
        }

        return arr;
    }
}
