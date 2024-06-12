
using System.Text.Json.Serialization;

var sol = new Solution();

//Console.WriteLine(sol.MaxLengthBetweenEqualCharacters("abca"));
//Console.WriteLine(sol.MaxLengthBetweenEqualCharacters("aa"));
//Console.WriteLine(sol.MaxLengthBetweenEqualCharacters("cbzxy"));

Console.WriteLine(sol.MaxLengthBetweenEqualCharacters("mgntdygtxrvxjnwksqhxuxtrv"));


public class Solution
{
    public int MaxLengthBetweenEqualCharacters(string s)
    {
        var hasMap=new Dictionary<char, int>();


        for(int i = 0; i < s.Length; i++)
        {
            if (!hasMap.ContainsKey(s[i]))
            {

            }
            else
            {
                hasMap[s[i]] = i;
                
            }
        }

        int maxDistance = -1;

        foreach(var list in hasMap.Values)
        {
            int distance=-1;
            var listLength = list.Count();
            
           if(listLength>=2)
                distance = list[^1] - list[0]-1;

           maxDistance=Math.Max(distance, maxDistance);
        }

        return maxDistance;

    }
}


//m g n t d y g t x r v  x  j  n  w  k  s  q  h  x  u  x  t  r  v
//0 1 2 3 4 5 6 7 8 9 10 11 12 13 14 15 16 17 18 19 20 21 22 23 24