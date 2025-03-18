// https://leetcode.com/problems/valid-palindrome/

public class Solution
{
    public bool IsPalindrome(string s)
    {
        int leftPointer = 0;
        int rightPointer = s.Length - 1;

        while (leftPointer <= rightPointer)
        {
            if (!char.IsLetterOrDigit(s[leftPointer]))
            {
                leftPointer++;
            }
            else if (!char.IsLetterOrDigit(s[rightPointer]))
            {
                rightPointer--;
            }
            else if (char.ToLower(s[leftPointer]) != char.ToLower(s[rightPointer]))
            {
                return false;
            }
            else
            {
                leftPointer++;
                rightPointer--;
            }
        }

        return true;
    }
}