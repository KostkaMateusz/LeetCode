// https://leetcode.com/problems/maximum-score-after-splitting-a-string/


public class Solution
{
    public int MaxScore(string s)
    {
        int score = 0;

        int zeroScore = 0;
        int oneScore = s.Count(x => x == '1');

        for (int i=0;i<s.Length-1;i++)
        {

            var element = s[i];
            
            if (element == '0')
            {
                zeroScore++;
            }
            else
            {
                oneScore--;
            }

            score = Math.Max(score, zeroScore + oneScore);
        }

        return score;
    }
}