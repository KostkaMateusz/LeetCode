var sol = new Solution();

sol.NextGreaterElement(nums1 : [4,1,2], nums2 : [1,3,4,2]);

public class Solution
{
    public int[] NextGreaterElement(int[] nums1, int[] nums2)
    {
        var lookUpTable = new Dictionary<int, int>();

        for (int i = 0; i < nums2.Length; i++)
        {
            for (int j = i; j < nums2.Length; j++)
            {
                if (nums2[j] > nums2[i])
                {
                    lookUpTable[nums2[i]] = nums2[j];
                    break;
                }
            }

            if (!lookUpTable.ContainsKey(nums2[i]))
                lookUpTable[nums2[i]] = -1;
        }

        var output = new int[nums1.Length];

        for (int i = 0; i < nums1.Length; i++)
        {
            output[i] = lookUpTable[nums1[i]];
        }

        return output;
    }
}