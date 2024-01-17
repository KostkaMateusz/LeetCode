//https://leetcode.com/problems/replace-elements-with-greatest-element-on-right-side/description/

var sol = new Solution();
sol.ReplaceElements([17, 18, 5, 4, 6, 1]);
sol.ReplaceElements([400]);

public class Solution
{
    public int[] ReplaceElements(int[] arr)
    {
        int rightMax = arr[^1];
        arr[^1] = -1;

        for(int i = arr.Length - 2; i >= 0; i--)
        {
            var temp = arr[i];
            arr[i] = rightMax;
            rightMax=Math.Max(rightMax, temp);
        }
        return arr;
    }
}