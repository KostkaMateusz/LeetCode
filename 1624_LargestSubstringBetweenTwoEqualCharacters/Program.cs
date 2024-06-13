
using System.Text.Json.Serialization;

var sol = new Solution();

//Console.WriteLine(sol.MaxLengthBetweenEqualCharacters("abca"));
//Console.WriteLine(sol.MaxLengthBetweenEqualCharacters("aa"));
//Console.WriteLine(sol.MaxLengthBetweenEqualCharacters("cbzxy"));
//Console.WriteLine(sol.MaxLengthBetweenEqualCharacters("mgntdygtxrvxjnwksqhxuxtrv"));

public class Solution
{
    public int MaxLengthBetweenEqualCharacters(string s)
    {
        var hasMap=new Dictionary<char, int>();
        int maxDistance = -1;

        for(int i = 0; i < s.Length; i++)        
            if (hasMap.TryGetValue(s[i], out int value))            
                maxDistance=Math.Max(maxDistance, i-value-1 );            
            else            
                hasMap[s[i]] = i;       

        return maxDistance;
    }
}