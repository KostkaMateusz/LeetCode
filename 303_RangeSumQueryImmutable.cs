// https://leetcode.com/problems/range-sum-query-immutable/description/


public class NumArray
{
    private readonly int[] _numsSum;

    public NumArray(int[] nums)
    {
        _numsSum = new int[nums.Length + 1];

        for (int i = 0; i < nums.Length; i++)
        {

            _numsSum[i + 1] = nums[i] + _numsSum[i]; ;
        }

    }

    public int SumRange(int left, int right)
    {
        return _numsSum[right + 1] - _numsSum[left];
    }
}

