// https://leetcode.com/problems/palindrome-number/

public class Solution
{
    public bool IsPalindrome(int x)
    {
        if (x < 0)
        {
            return false;
        }

        string str = x.ToString();
        return str == new string(str.Reverse().ToArray());
    }
}
