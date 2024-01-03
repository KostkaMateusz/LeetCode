//https://leetcode.com/problems/valid-parentheses/description/

var sol = new Solution();

bool output;

output = sol.IsValid("()[]{}");
Console.WriteLine(output);

output = sol.IsValid("()");
Console.WriteLine(output);

output = sol.IsValid("(]");
Console.WriteLine(output);

output = sol.IsValid("{");
Console.WriteLine(output);

output = sol.IsValid("]]");
Console.WriteLine(output);

output = sol.IsValid("){");
Console.WriteLine(output);

output = sol.IsValid("[[");
Console.WriteLine(output);

output = sol.IsValid("{[");
Console.WriteLine(output);

public class Solution
{
    public bool IsValid(string s)
    {
        var stack = new Stack<char>();
        
        foreach (char c in s)
        {
            if (c == '(' || c == '[' || c == '{')
            {
                stack.Push(c);
                continue;
            }

            var openingSymbol = c switch
            {
                ')' => '(',
                ']' => '[',
                '}' => '{',                
            };

            if (stack.Count == 0 || stack.Pop() != openingSymbol)
                return false;
        }
        return stack.Count==0;
    }
}