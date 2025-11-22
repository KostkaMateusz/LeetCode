// https://leetcode.com/problems/merge-strings-alternately/

var sol = new Solution();

sol.MergeAlternately(word1: "abc", word2: "pqr");


public class Solution
{
    public string MergeAlternately(string word1, string word2)
    {
        int pointer1 = 0;
        int pointer2 = 0;
        int mergePointer = 0;
        char[] mergeString = new char[word1.Length + word2.Length];

        while (mergePointer != word1.Length + word2.Length)
        {
            if (pointer1 < word1.Length)
            {
                mergeString[mergePointer] = word1[pointer1];
                mergePointer++;
                pointer1++;
            }

            if (pointer2 < word2.Length)
            {
                mergeString[mergePointer] = word2[pointer2];
                mergePointer++;
                pointer2++;
            }

        }
       
        return new string(mergeString);

    }
}
