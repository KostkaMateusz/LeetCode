// https://leetcode.com/problems/reverse-string/description/

var sol = new Solution();

sol.ReverseString(['h','e','l','l','o']);


public class Solution
{
    public void ReverseString(char[] s)
    {
        int pointerA = 0;
        int pointerB = s.Length - 1;


        while (pointerA <= pointerB)
        {
            (s[pointerA], s[pointerB]) = (s[pointerB], s[pointerA]);
            
            pointerA++;
            pointerB--;
        }
    }
}