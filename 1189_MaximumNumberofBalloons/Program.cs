// https://leetcode.com/problems/maximum-number-of-balloons/

var sol = new Solution();

var text = "nlaebolko";

var output = sol.MaxNumberOfBalloons(text);

Console.WriteLine();
public class Solution
{
    public int MaxNumberOfBalloons(string text)
    {
        // balloon
        // b a l o n
        int[] ballon = new int[5];

        foreach (var s in text)
        {
            switch (s)
            {
                case 'b':
                    ballon[0] = ++ballon[0];
                    break;
                case 'a':
                    ballon[1] = ++ballon[1];
                    break;
                case 'l':
                    ballon[2] = ++ballon[2];
                    break;
                case 'o':
                    ballon[3] = ++ballon[3];
                    break;
                case 'n':
                    ballon[4] = ++ballon[4];
                    break;
            }
        }

        ballon[2] = ballon[2] == 0 ? 0 : ballon[2] / 2;
        ballon[3] = ballon[3] == 0 ? 0 : ballon[3] / 2;

        return ballon.Min();
    }
}


public class Solution2
{
    public int MaxNumberOfBalloons(string text)
    {
        // balloon
        Dictionary<char, int> ballonsMap = new()
        {
            ['b'] = 0,
            ['a'] = 0,
            ['l'] = 0,
            ['o'] = 0,
            ['n'] = 0,
        };

        foreach (var s in text)
        {
            if (ballonsMap.ContainsKey(s))
            {
                ballonsMap[s]++;
            }
        }

        ballonsMap['l'] = ballonsMap['l'] == 0 ? 0 : ballonsMap['l'] / 2;
        ballonsMap['o'] = ballonsMap['o'] == 0 ? 0 : ballonsMap['o'] / 2;

        return ballonsMap.Values.Min();
    }
}