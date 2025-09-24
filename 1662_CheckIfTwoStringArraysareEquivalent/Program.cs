// https://leetcode.com/problems/check-if-two-string-arrays-are-equivalent/

public class Solution
{
    public bool ArrayStringsAreEqual(string[] word1, string[] word2)
    {
        string string1 = string.Join("", word1);
        string string2 = string.Join("", word2);

        if (string1.Length != string2.Length)
        {
            return false;
        }


        for (int i = 0; i < string1.Length; i++)
        {
            if (string1[i] != string2[i])
            {
                return false;
            }
        }
        return true;

    }
}