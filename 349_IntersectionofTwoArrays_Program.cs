// https://leetcode.com/problems/intersection-of-two-arrays/

public class Solution
{
    public int[] Intersection(int[] nums1, int[] nums2)
    {
        var num1 = new HashSet<int>(nums1);
        var num2 = new HashSet<int>(nums2);

        return num1.Intersect(num2).ToArray();
    }
}
