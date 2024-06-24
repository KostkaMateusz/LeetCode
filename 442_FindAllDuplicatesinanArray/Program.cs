
var sol = new Solution();

sol.FindDuplicates([4, 3, 2, 7, 8, 2, 3, 1]);



public class Solution
{
    public IList<int> FindDuplicates(int[] nums)
    {
        var output = new List<int>();

        for (int i = 0; i < nums.Length; i++)
        {
            var num = Math.Abs(nums[i]);

            if (nums[num - 1] <= 0)
            {
                output.Add(num);
            }

            nums[num - 1] = nums[num - 1] * (-1);
        }
        return output;
    }
}




public class Solution_Breaking_Space_Constrain
{
    public IList<int> FindDuplicates(int[] nums)
    {

        var map = new int[nums.Length+1];
        var output = new List<int>();

        for (int i = 0; i < nums.Length; i++)
        {
            map[nums[i]]++;
            if (map[nums[i]] == 2)
            {
                output.Add(nums[i]);
            }

        }
        return output;


    }
}