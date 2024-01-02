//https://leetcode.com/problems/maximum-number-of-words-found-in-sentences/description/
var sol = new Solution();

Console.WriteLine(sol.MostWordsFound(["alice and bob love leetcode", "i think so too", "this is great thanks very much"]));


public class Solution
{
    public int MostWordsFound(string[] sentences)
    {
        int max = -1;
        foreach (string sentence in sentences)
        {
            var words = sentence.Split(' ');
                    
            max=Math.Max(max, words.Length);                      
        }
        return max;
    }
}


public class SolutionFirst
{
    public int MostWordsFound(string[] sentences)
    {
        var listofWords = new List<int>();
        foreach (string sentence in sentences)
        {
            var words = sentence.Split(' ');

            listofWords.Add(words.Length);
        }

        return listofWords.Max();
    }
}