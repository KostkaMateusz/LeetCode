// https://leetcode.com/problems/majority-element-ii/

public class Solution
{
    public IList<int> MajorityElement(int[] nums)
    {
        int cnt1 = 0;
        int cnt2 = 0;
        int number1 = -1;
        int number2 = -1;


        foreach (int num in nums)
        {
            if (num == number1)
            {
                cnt1++;
            }
            else if (num == number2)
            {
                cnt2++;
            }
            else if (cnt1 == 0)
            {
                number1 = num;
                cnt1++;
            }
            else if (cnt2 == 0)
            {
                number2 = num;
                cnt2++;
            }
            else
            {
                cnt1--;
                cnt2--;
            }
        }


        cnt1 = 0;
        cnt2 = 0;
        foreach (int num in nums)
        {
            if (num == number1) cnt1++;
            else if (num == number2) cnt2++;
        }

        List<int> res = [];
        if (cnt1 > nums.Length / 3) res.Add(number1);
        if (cnt2 > nums.Length / 3) res.Add(number2);

        return res;
    }
}





public class Solution1
{
    public IList<int> MajorityElement(int[] nums)
    {
        Dictionary<int, int> generalCounter = [];

        foreach (var num in nums)
        {
            if (!generalCounter.TryAdd(num, 1))
            {
                generalCounter[num] += 1;

            }
        }

        IList<int> MajorityElement3 = [];
        int requiredLength = nums.Length / 3;

        foreach (var (key, value) in generalCounter)
        {
            if (value > requiredLength)
            {
                MajorityElement3.Add(key);
            }
        }


        return MajorityElement3;
    }
}