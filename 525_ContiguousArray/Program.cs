

var sol = new Solution();

sol.FindMaxLength([0, 1, 1, 0, 1, 1, 1, 0]);



public class Solution
{
    public int FindMaxLength(int[] nums)
    {

        var zero = 0;
        var one = 0;

        var res = 0;
        var diff_index= new Dictionary<int, int>();

        for(int i = 0; i < nums.Length; i++)
        {
            if (nums[i] == 0)
            {
                zero++;
            }
            else
            {
                one++;
            }

            if(!diff_index.ContainsKey(one - zero))
            {
                diff_index[one - zero]=i;
            }

            if (one == zero)
            {
                res=one+zero;
            }
            else
            {
                res = Math.Max(res, i - diff_index[one - zero]);
            }


        }
        return res;

    }
}