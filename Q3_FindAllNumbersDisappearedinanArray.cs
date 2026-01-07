public class Solution
{
    public IList<int> FindDisappearedNumbers(int[] nums)
    {
        HashSet<int> unique = [.. nums];
        List<int> output=[];
        for (int i = 1; i <= nums.Length; i++)
        {
            if (!unique.Contains(i))
            {
                output.Add(i);
            }
        }

        return output;
    }
}