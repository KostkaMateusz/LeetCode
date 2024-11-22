// https://leetcode.com/problems/length-of-last-word/


public class Solution
{
    public int LengthOfLastWord(string s)
    {
        var len = 0;

        var pointer = s.Length - 1;

        while (pointer >= 0)
        {
            if (s[pointer] == ' ')
                pointer--;
            else
            {
                while (pointer >= 0)
                {
                    if (s[pointer] != ' ')
                    {
                        pointer--;
                        len++;
                    }
                    else
                    {
                        return len;
                    }
                }
            }
        }

        return len;
    }
}