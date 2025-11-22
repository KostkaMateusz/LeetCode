// https://leetcode.com/problems/find-all-numbers-disappeared-in-an-array/description/


public class Solution
{
    public IList<int> FindDisappearedNumbers(int[] nums)
    {
        HashSet<int> missingNumbers = new HashSet<int>();

        for (int i = 1; i < nums.Length + 1; i++)
        {
            missingNumbers.Add(i);
        }


        for (int i = 0; i < nums.Length; i++)
        {
            missingNumbers.Remove(nums[i]);
        }

        return missingNumbers.ToList();
    }
}
