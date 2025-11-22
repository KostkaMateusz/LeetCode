// https://leetcode.com/problems/find-first-palindromic-string-in-the-array/


public class Solution
{
    public string FirstPalindrome(string[] words)
    {


        foreach (string currentWord in words)
        {


            int leftPointer = 0;
            int rightPointer = currentWord.Length-1;
            bool isPalindrom = true;
            while (leftPointer <= rightPointer)
            {
                if (currentWord[leftPointer] != currentWord[rightPointer])
                {
                    isPalindrom = false;
                    break;
                }

                leftPointer++;
                rightPointer--;
            }

            if (isPalindrom)
            {
                return currentWord;
            }
        }
        return "";
    }

}
