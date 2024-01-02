//https://leetcode.com/problems/count-pairs-whose-sum-is-less-than-target/description/

var sol = new Solution();

var input = new List<int> { -1, 1, 2, 3, 1 };

Console.WriteLine(sol.CountPairs(target:2,nums:input));

public class Solution
{
    public int CountPairs(IList<int> nums, int target)
    {
        int count = 0;

        for(int pointerA = 0; pointerA < nums.Count; pointerA++)
        {
            int pointerB = pointerA+1;
            while(pointerB < nums.Count)
            {
                if (nums[pointerA] + nums[pointerB]< target)
                {
                    count++;
                }
                pointerB++;
            }
        }
        return count;
    }
}