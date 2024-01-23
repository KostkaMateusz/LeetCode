//https://leetcode.com/problems/reverse-string/

var sol = new Solution();

char[] array = ['h'];

sol.ReverseString(array);


Console.WriteLine(array);

public class Solution
{
    public void ReverseString(char[] s)
    {
        int leftPointer = 0;
        int rightPointer = s.Length-1;

        while (leftPointer <= rightPointer)
        {
            var rightTemp = s[rightPointer];
            s[rightPointer] = s[leftPointer];
            s[leftPointer]=rightTemp;

            leftPointer++;
            rightPointer--;
        }       
    }
}