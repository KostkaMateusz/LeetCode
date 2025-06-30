// https://leetcode.com/problems/circular-sentence/description/


public class Solution
{
    public bool IsCircularSentence(string sentence)
    {
        //check sentence wide cicular
        if (sentence[0] != sentence[^1])
        {
            return false;
        }

        int spaceIndex = 0;

        while (spaceIndex + 1 < sentence.Length)
        {
            if (sentence[spaceIndex] == ' ')
            {
                if (sentence[spaceIndex - 1] != sentence[spaceIndex + 1])
                {
                    return false;
                }
            }
            spaceIndex++;
        }

        return true;
    }
}
