// https://leetcode.com/problems/reverse-words-in-a-string-iii/description/

using System.Linq;
using System.Text;

var sol = new Solution();


System.Console.WriteLine(sol.ReverseWords("Let's take LeetCode contest"));
public class Solution
{
    public string ReverseWords(string s)
    {
        var words = s.Split(' ');

        for (int i = 0; i < words.Length; i++)
        {

            words[i] = new string(words[i].Reverse().ToArray());

        }

        return string.Join(' ', words);
    }
}

