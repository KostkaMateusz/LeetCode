public class Solution
{
    public int[] FindErrorNums(int[] nums)
    {
        HashSet<int> numbers = [];

        int[] errorNumbers = [-1, -1];

        foreach (var item in nums)
        {
            if (numbers.Add(item) is false)
            {
                errorNumbers[0] = item;
            }
        }

        for (int i = 1; i <= nums.Length; i++)
        {
            if (numbers.Contains(i) is false)
            {
                errorNumbers[1] = i;

            }
        }
        return errorNumbers;
    }
}