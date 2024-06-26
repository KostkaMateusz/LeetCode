﻿


var sol = new Solution();



Console.WriteLine(sol.MaxScore("011101"));


Console.WriteLine(sol.MaxScore("00111"));


public class Solution
{
    public int MaxScore(string s)
    {
        var zero = 0;
        var one = s.Count(x => x == '1');
        var result = 0;


        for(var i=0; i<s.Length-1; i++)
        {
            if (s[i] == '0')
            {
                zero++;
            }
            else
            {
                one--;
            }
            result=Math.Max(result, zero+one);
        }
        return result;
    }
}
