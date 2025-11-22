// https://leetcode.com/problems/divide-array-into-equal-pairs/


public class Solution
{
    public bool DivideArray(int[] nums)
    {
        HashSet<int> isThere = new();

        foreach (var num in nums)
        {
            if (!isThere.Remove(num))
            {
                isThere.Add(num);
            }
        }

        return isThere.Count() == 0;
    }
}


public class Solution1
{
    public bool DivideArray(int[] nums)
    {
        Dictionary<int, int> elementCounter = new();

        foreach (var num in nums)
        {
            if (!elementCounter.TryAdd(num, 1))
            {
                elementCounter[num] += 1;
            }
        }


        foreach (var values in elementCounter.Values)
        {
            if (values % 2 != 0)
            {
                return false;
            }
        }

        return true;

    }
}
