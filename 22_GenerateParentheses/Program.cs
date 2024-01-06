//https://leetcode.com/problems/generate-parentheses/description/

var sol = new Solution();

var result=sol.GenerateParenthesis(3);

Console.WriteLine(result.Count);

public class Solution
{
    public IList<string> GenerateParenthesis(int n)
    {
        Stack<char> stack = [];
        List<string> res = [];

        InternalBackTrack(0, 0);

        void InternalBackTrack(int openNumber, int closedNumber )
        {
            //return IF open == closed == n
            if(openNumber==closedNumber && closedNumber== n)
            {
                res.Add(string.Join("",stack.Reverse()));
                return;
            }

            //only add open paranthesis if open < n
            if(openNumber < n)
            {
                stack.Push('(');
                InternalBackTrack(openNumber+1, closedNumber );
                stack.Pop();
            }

            //only add a closing paranthesis if closed<open
            if(closedNumber < openNumber)
            {
                stack.Push(')');
                InternalBackTrack(openNumber, closedNumber + 1);
                stack.Pop();
            }
        }
        return res;
    }
}

