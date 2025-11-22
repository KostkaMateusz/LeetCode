// https://leetcode.com/problems/design-hashset/

public class MyHashSet
{
    private readonly bool[] _array = new bool[(int)Math.Pow(10, 6) + 1];

    public MyHashSet()
    {
        Array.Fill(_array, false);
    }

    public void Add(int key) => _array[key] = true;

    public void Remove(int key) => _array[key] = false;

    public bool Contains(int key) => _array[key];
}
