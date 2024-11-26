// https://leetcode.com/problems/design-hashmap/description/


public class MyHashMap
{
    private readonly int[] _map = new int[(int)Math.Pow(10,6)+1];
    
    public MyHashMap()
    {
        Array.Fill(_map, -1);
    }

    public void Put(int key, int value) => _map[key] = value;
    
    public int Get(int key) => _map[key];
    
    public void Remove(int key) => _map[key] = -1;
    
}

/**
 * Your MyHashMap object will be instantiated and called as such:
 * MyHashMap obj = new MyHashMap();
 * obj.Put(key,value);
 * int param_2 = obj.Get(key);
 * obj.Remove(key);
 */