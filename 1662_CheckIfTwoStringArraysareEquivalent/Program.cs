









public class Solution
{
    public bool ArrayStringsAreEqual(string[] word1, string[] word2)
    {
        var combinedWord1=string.Join("", word1);
        var combinedWord2 = string.Join("", word2);

        return string.Equals(combinedWord1, combinedWord2);
    }
}