// https://leetcode.com/problems/next-greater-element-i/description/

public class Solution
{
    public int[] NextGreaterElement(int[] nums1, int[] nums2)
    {
        Dictionary<int, int> nums1Idx = [];

        for (int i = 0; i < nums1.Length; i++)
        {
            nums1Idx.Add(nums1[i], i);
        }

        int[] res = new int[nums1.Length];
        Array.Fill(res, -1);

        Stack<int> stack = [];

        foreach (int num in nums2)
        {
            while (stack.Any() && num > stack.Peek())
            {
                int val = stack.Pop();
                int idx = nums1Idx[val];
                res[idx] = num;
            }

            if (nums1Idx.ContainsKey(num))
            {
                stack.Push(num);
            }
        }

        return res;
    }
}
