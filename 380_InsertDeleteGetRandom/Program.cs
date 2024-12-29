// https://leetcode.com/problems/insert-delete-getrandom-o1/description/


public class RandomizedSet
{
    private readonly Dictionary<int, int> _dict;
    private readonly List<int> _list;
    private readonly Random _random;

    public RandomizedSet()
    {
        _dict = [];
        _list = [];
        _random = new();
    }

    public bool Insert(int val)
    {
        bool contains = _dict.ContainsKey(val);

        if (contains is false)
        {
            _list.Add(val);
            _dict[val] = _list.Count - 1;
        }

        return !contains;
    }

    public bool Remove(int val)
    {
        bool contains = _dict.ContainsKey(val);

        if (contains is true)
        {
            _dict.Remove(val, out var removedIndex);

            var lastIndex = _list.Count - 1;

            if (removedIndex != lastIndex)
            {
                var lastNumber = _list[lastIndex];
                _list[removedIndex] = lastNumber;
                _dict[lastNumber] = removedIndex;
            }

            _list.RemoveAt(lastIndex);
        }

        return contains;
    }

    public int GetRandom()
    {
        return _list[_random.Next(_list.Count)];
    }
}