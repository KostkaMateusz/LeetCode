// https://leetcode.com/problems/insert-delete-getrandom-o1/description/


public class RandomizedSet
{
    private readonly HashSet<int> _set;
    private readonly Random _random;

    public RandomizedSet()
    {
        _set = new HashSet<int>();
        _random = new Random();
    }

    public bool Insert(int val)
    {
        return _set.Add(val);
    }

    public bool Remove(int val)
    {
        return _set.Remove(val);
    }

    public int GetRandom()
    {
        return _set.ElementAt(_random.Next(0, _set.Count) );
    }
}