// https://leetcode.com/problems/maximum-number-of-balloons/

var sol = new Solution();

Console.WriteLine(sol.MaxNumberOfBalloons("nlaebolko"));
Console.WriteLine(sol.MaxNumberOfBalloons("loonbalxballpoon"));

public class Solution 
{
    public int MaxNumberOfBalloons(string text)
    {
        Dictionary<char, int> ballonLetters = new()
            {
                {'b',0},
                {'a',0},
                {'l',0},
                {'o',0},
                {'n',0}
            };

        foreach (var letter in text)
        {
            if (ballonLetters.ContainsKey(letter))
            {
                ballonLetters[letter]++;
            }
        }
        
        ballonLetters['l'] /= 2;
        ballonLetters['o'] /= 2;

        return ballonLetters.Values.Min();
    }
}