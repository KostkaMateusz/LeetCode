

string[] words = ["leet", "code"];
char x = 'e';

var sol = new Solution();

var results=sol.FindWordsContaining(words, x);

Console.WriteLine();



public class Solution
{
    public IList<int> FindWordsContaining(string[] words, char x)
    {
        var results= new List<int>();

        for(int i=0;i<words.Length;i++)
            if (words[i].Contains(x))
                results.Add(i);

        return results;
    }
}