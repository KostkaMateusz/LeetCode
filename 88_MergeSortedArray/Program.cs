// https://leetcode.com/problems/merge-sorted-array/


public class Solution
{
    public void Merge(int[] nums1, int m, int[] nums2, int n)
    {
        int pointer1 = m - 1;
        int pointer2 = n - 1;


        for (int insertPointer = m + n - 1; insertPointer >= 0; insertPointer--)
        {
            if (pointer1 >= 0 && pointer2 >= 0)
            {

                if (nums1[pointer1] > nums2[pointer2])
                {

                    nums1[insertPointer] = nums1[pointer1--];

                }
                else
                {

                    nums1[insertPointer] = nums2[pointer2--];
                }

            }
            else if (pointer1 >= 0)
            {
                nums1[insertPointer] = nums1[pointer1--];
            }
            else
            {
                nums1[insertPointer] = nums2[pointer2--];

            }
        }

    }
}