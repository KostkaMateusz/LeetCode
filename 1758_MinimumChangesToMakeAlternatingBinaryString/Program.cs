// https://leetcode.com/problems/minimum-changes-to-make-alternating-binary-string/description/

public class Solution
{
    public int MinOperations(string s)
    {
        var seaker = '0';

        var zeroCounter = 0;
        var oneCounter = 0;

        for (int i = 0; i < s.Length; i++)
        {
            if (i % 2 == 0)
            {
                seaker = '0';
            }
            else
            {
                seaker = '1';
            }

            if (s[i] != seaker)
                zeroCounter++;
            else
                oneCounter++;
        }
        return Math.Min(zeroCounter, oneCounter);
    }
}