var sol = new Solution();

var res = sol.IsMonotonic(nums: new int[] { 1, 2, 2, 3 });
Console.WriteLine(res);


res = sol.IsMonotonic(nums: new int[] { 1, 1, 0 });
Console.WriteLine(res);

res = sol.IsMonotonic(nums: new int[] { 1, 3, 2 });
Console.WriteLine(res);


public class Solution
{
    private delegate bool Compare(int prev, int next);

    public bool IsMonotonic(int[] nums)
    {
        if (nums.Length < 2)
        {
            return true;
        }

        Compare? comparator = null;

        for (int i = 0; i < nums.Length - 1; i++)
        {
            var prev = nums[i];
            var next = nums[i + 1];
            
            if (comparator is not null)
            {
                if (!comparator(prev, next))
                {
                    return false;
                }
            }
            else
            {
                if (prev != next)
                {
                    if (prev > next)
                    {
                        comparator = (a, b) => a >= b;
                    }
                    else
                    {
                        comparator = (a, b) => a <= b;
                    }
                }
            }
        }

        return true;
    }
}