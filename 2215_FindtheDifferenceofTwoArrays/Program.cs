// https://leetcode.com/problems/find-the-difference-of-two-arrays/description/

public class Solution
{
    public IList<IList<int>> FindDifference(int[] nums1, int[] nums2)
    {
        HashSet<int> set1 = new HashSet<int>(nums1);
        HashSet<int> set2 = new HashSet<int>(nums2);


        return [set1.Except(set2).ToList(), set2.Except(set1).ToList()];
    }
}