//https://leetcode.com/problems/truncate-sentence/description/

var sol = new Solution();

var st=sol.TruncateSentence("Hello how are you Contestant",4);

Console.WriteLine(st);
public class Solution
{
    public string TruncateSentence(string s, int k)
    {
        var output= s.Split(" ").Take(k).ToArray();

        return string.Join(" ",output);
    }
}