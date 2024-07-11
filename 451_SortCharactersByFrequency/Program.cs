using System.Text;

var sol = new Solution();


Console.WriteLine(sol.FrequencySort("tree"));


public class Solution
{
    public string FrequencySort(string s)
    {
        var hashMap=new Dictionary<char, int>();

        foreach(var character in s)
        {
            if (hashMap.ContainsKey(character))
            {
                hashMap[character]++;
            }
            else
            {
                hashMap[character]= 1;
            }
        }

        var sortedKeys = hashMap.OrderByDescending(kvp=>kvp.Value).Select(kvp=>kvp.Key);
        var stringBuilder = new StringBuilder();

        foreach (var key in sortedKeys)
        {
            for(var i = 0; i < hashMap[key]; i++)
            {
                stringBuilder.Append(key);

            }

        }

        return stringBuilder.ToString();

    }
}