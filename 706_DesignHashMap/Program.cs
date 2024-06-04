var hash = new MyHashMap();


Console.WriteLine(hash.Get(14));

public sealed class MyHashMap
{
    private readonly int[] _internalArray;
    public MyHashMap()
    {
        _internalArray = new int[1000001];
        Array.Fill(_internalArray,-1);
    }

    public void Put(int key, int value)
    {
        _internalArray[key] = value;
    }

    public int Get(int key)
    {
        return _internalArray[key];
    }

    public void Remove(int key)
    {
        _internalArray[key] = -1;
    }
}

/**
 * Your MyHashMap object will be instantiated and called as such:
 * MyHashMap obj = new MyHashMap();
 * obj.Put(key,value);
 * int param_2 = obj.Get(key);
 * obj.Remove(key);
 */