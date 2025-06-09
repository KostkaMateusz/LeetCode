// https://leetcode.com/problems/number-of-senior-citizens/description/


var sol = new Solution();

sol.CountSeniors(["7868190130M7522", "5303914400F9211", "9273338290F4010"]);

public class Solution
{
    public int CountSeniors(string[] details)
    {

        int over60 = 0;

        foreach (var str in details)
        {

            var firstDigit = str[11];

            if (firstDigit > '6')
            {
                over60++;
            }
            else if (firstDigit == '6')
            {
                if (str[12] > '0')
                {
                    over60++;
                }
            }

        }
        return over60;
    }
}