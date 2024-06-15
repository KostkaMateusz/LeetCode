

var sol = new Solution();


sol.Intersection(nums1 : [1, 2, 2, 1], nums2 : [2, 2]);


public class Solution
{
    public int[] Intersection(int[] nums1, int[] nums2)
    {

        var hashSet1= new HashSet<int>(nums1);
        var hashSet2 = new HashSet<int>(nums2);

        var intersection=new List<int>();


        foreach(var num1 in hashSet1)
        {
            if (hashSet2.Contains(num1))
            {
                intersection.Add(num1);
            }
        }

        return intersection.ToArray();
    }
}