//https://leetcode.com/problems/length-of-last-word/

var sol = new Solution();

Console.WriteLine(sol.LengthOfLastWord("Hello World"));
Console.WriteLine(sol.LengthOfLastWord("   fly me   to   the moon  "));
Console.WriteLine(sol.LengthOfLastWord("luffy is still joyboy"));
Console.WriteLine(sol.LengthOfLastWord("a"));
Console.WriteLine(sol.LengthOfLastWord(" a "));

public class Solution
{
    public int LengthOfLastWord(string s)
    {
        char[] characters = s.ToCharArray();

        int characterCount = 0;
        int pointer = s.Length - 1;

        //filter non letters from end
        while (pointer >= 0 && Char.IsWhiteSpace(characters[pointer]))
        {
            pointer--;
        }

        //count letters
        while (pointer >= 0 && Char.IsLetterOrDigit(characters[pointer]))
        {
            characterCount++;
            pointer--;
        }
        return characterCount;
    }
}