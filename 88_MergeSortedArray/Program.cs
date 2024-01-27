//https://leetcode.com/problems/merge-sorted-array/

var sol = new Solution();

sol.Merge(nums1: [1, 2, 3, 0, 0, 0], m: 3, nums2: [2, 5, 6], n: 3);
sol.Merge(nums1: [1], m: 1, nums2: [], n: 0);
sol.Merge(nums1: [0], m: 0, nums2: [1], n: 1);

public class Solution
{
    public void Merge(int[] nums1, int m, int[] nums2, int n)
    {
        int nums1Pointer = m - 1;
        int nums2Pointer = n - 1;
        int insertingPointer = nums1.Length - 1;

        while (insertingPointer >= 0)
        {
            if (nums1Pointer >= 0 && nums2Pointer >= 0)
            {
                nums1[insertingPointer] = nums1[nums1Pointer] > nums2[nums2Pointer] ? nums1[nums1Pointer--] : nums2[nums2Pointer--];
            }
            else if (nums1Pointer >= 0)
            {
                nums1[insertingPointer] = nums1[nums1Pointer--];
            }
            else
            {
                nums1[insertingPointer] = nums2[nums2Pointer--];
            }

            insertingPointer--;
        }
        return;
    }
}