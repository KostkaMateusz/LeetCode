//https://leetcode.com/problems/min-stack/description/

MinStack minStack = new();
minStack.Push(-2);
minStack.Push(0);
minStack.Push(-3);
minStack.GetMin(); // return -3
minStack.Pop();
minStack.Top();    // return 0
minStack.GetMin(); // return -2

public sealed class MinStack()
{
    private readonly Stack<int> valueStack = new();
    private readonly Stack<int> minStack = new();
    
    public void Push(int val)
    {
        valueStack.Push(val);

        if (minStack.TryPeek(out int result) is false)
            result = val;       

        minStack.Push(Math.Min(result, val));
    }

    public void Pop()
    {
        minStack.Pop();
        valueStack.Pop();
    }

    public int Top() => valueStack.Peek();
    public int GetMin() => minStack.Peek();    
}