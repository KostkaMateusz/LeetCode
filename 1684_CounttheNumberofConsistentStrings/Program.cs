// https://leetcode.com/problems/count-the-number-of-consistent-strings/description/


public class Solution
{
    public int CountConsistentStrings(string allowed, string[] words)
    {
        HashSet<char> allowedChars = new(allowed);
        int counter = 0;

        foreach (var word in words)
        {
            bool addToCount = true;
            foreach (char c in word)
            {
                if (!allowedChars.Contains(c))
                {
                    addToCount = false;
                    break;
                }
            }

            if (addToCount)
            {
                counter++;
            }
        }

        return counter;
    }
}