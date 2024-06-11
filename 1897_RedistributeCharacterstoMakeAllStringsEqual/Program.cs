


var sol = new Solution();


Console.WriteLine(sol.MakeEqual(["abc", "aabc", "bc"]));

public class Solution
{
    public bool MakeEqual(string[] words)
    {
        var hashMap=new Dictionary<char, int>();

        foreach (var word in words)
        {
            foreach(var letter in word)
            {
                if(hashMap.ContainsKey(letter))
                {
                    hashMap[letter]++;
                }
                else
                {
                    hashMap.Add(letter, 1);
                }
            }
        }

        foreach(var count in hashMap.Values)
        {
            if(count % words.Length != 0)
            {
                return false;
            }
        }
        return true;
    }
}