//https://leetcode.com/problems/evaluate-reverse-polish-notation/description/

var sol = new Solution();
int result;

result=sol.EvalRPN(["2", "1", "+", "3", "*"]);
Console.WriteLine(result);

result = sol.EvalRPN(["4", "13", "5", "/", "+"]);
Console.WriteLine(result);

result = sol.EvalRPN(["10", "6", "9", "3", "+", "-11", "*", "/", "*", "17", "+", "5", "+"]);
Console.WriteLine(result);


public sealed class Solution
{
    private static Dictionary<string, Func<int, int, int>> Operations = new()
    {
        {"+", (a, b) => a + b },
        {"-", (a, b) => a - b },
        {"*", (a, b) => a * b },
        {"/", (a, b) => a / b },
    };

    public int EvalRPN(string[] tokens)
    {
        Stack<int> operationBuffer = new();

        foreach (var token in tokens)
        {
            if (Operations.TryGetValue(token, out Func<int, int, int>? value))
            {
                var value1 = operationBuffer.Pop();
                var value2 = operationBuffer.Pop();

                var result = value.Invoke(value2, value1);

                operationBuffer.Push(result);
            }
            else
            {
                operationBuffer.Push(int.Parse(token));
            }
        }

        return operationBuffer.Pop();
    }
}