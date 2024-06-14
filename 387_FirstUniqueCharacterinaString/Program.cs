



var sol = new Solution();

sol.FirstUniqChar("loveleetcode");



public class Solution
{
    public int FirstUniqChar(string s)
    {
        var HashMap = new Dictionary<char, List<int>>();


        for(int i = 0; i < s.Length; i++)
        {
            if (HashMap.TryGetValue(s[i], out var value))
            {
                value.Add(i);
            }
            else
            {
                HashMap.Add(s[i], [i]);
            }

        }

        var uniqueIndices = HashMap.Values.Where(x => x.Count() == 1).Select(x => x[0]);

        return uniqueIndices.Any() ? uniqueIndices.Min() : -1;

    }
}