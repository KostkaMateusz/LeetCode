//https://leetcode.com/problems/check-if-two-string-arrays-are-equivalent/description/


public class Solution
{
    //Time Complexity: O(n)
    //Space Complexity: O(m + k) 
    public bool ArrayStringsAreEqual(string[] word1, string[] word2)
    {
        // Combine the individual strings in word1 into a single string
        var combinedWord1 = string.Join("", word1);

        // Combine the individual strings in word2 into a single string
        var combinedWord2 = string.Join("", word2);

        // Compare the two combined strings for equality
        return string.Equals(combinedWord1, combinedWord2);
    }
}