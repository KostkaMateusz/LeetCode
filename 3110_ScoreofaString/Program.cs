// https://leetcode.com/problems/score-of-a-strin

var sol = new Solution();

sol.ScoreOfString("hello");

public class Solution
{
    public int ScoreOfString(string s)
    {
        int Sum = 0;

        for (int i = 1; i < s.Length; i++)
        {
            int firstValue = s[i - 1];
            int secondValue = s[i];

            Sum += Math.Abs(firstValue - secondValue);

        }

        return Sum;
    }
}