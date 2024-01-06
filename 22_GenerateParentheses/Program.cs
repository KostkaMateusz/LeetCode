//https://leetcode.com/problems/generate-parentheses/description/

using System.Text;

var sol = new Solution();

var result=sol.GenerateParenthesis(10);

Console.WriteLine(result.Count);

public class Solution
{
    public IList<string> GenerateParenthesis(int n)
    {
        StringBuilder stack = new();
        List<string> res = [];

        InternalBackTrack(0, 0);

        void InternalBackTrack(int openNumber, int closedNumber )
        {
            //return IF open == closed == n
            if(openNumber==closedNumber && closedNumber== n)
            {
                res.Add(stack.ToString());
                return;
            }

            //only add open paranthesis if open < n
            if(openNumber < n)
            {
                stack.Append('(');
                InternalBackTrack(openNumber+1, closedNumber );
                stack.Remove(stack.Length - 1, 1);
            }

            //only add a closing paranthesis if closed<open
            if(closedNumber < openNumber)
            {
                stack.Append(')');
                InternalBackTrack(openNumber, closedNumber + 1);
                stack.Remove(stack.Length-1, 1);
            }
        }
        return res;
    }
}

