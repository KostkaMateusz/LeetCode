//https://leetcode.com/problems/valid-palindrome/

var sol = new Solution();

bool solution;

solution = sol.IsPalindrome("A man, a plan, a canal: Panama");
Console.WriteLine(solution);

solution = sol.IsPalindrome("  ");
Console.WriteLine(solution);

solution = sol.IsPalindrome("A");
Console.WriteLine(solution);

solution = sol.IsPalindrome("race a car");
Console.WriteLine(solution);

public class Solution
{
    public bool IsPalindrome(string s)
    {
        int leftPointer = 0;
        int rightPointer = s.Length-1;

        while (leftPointer < rightPointer)        
            if (Char.IsLetterOrDigit(s[leftPointer]) is false)
                leftPointer++;
            else if (Char.IsLetterOrDigit(s[rightPointer]) is false)
                rightPointer--;
            else if (Char.ToLower(s[leftPointer]) != Char.ToLower(s[rightPointer]))
                return false;
            else            
            {                
                leftPointer++;
                rightPointer--;
            }               
        return true;
    }
}