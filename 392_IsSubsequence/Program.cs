//https://leetcode.com/problems/is-subsequence/

var sol = new Solution();

bool sub;

sub=sol.IsSubsequence(s : "abc", t : "ahbgdc");
Console.WriteLine(sub);

sub = sol.IsSubsequence(s : "axc", t : "ahbgdc");
Console.WriteLine(sub);

public class Solution
{
    public bool IsSubsequence(string s, string t)
    {
        var tPointer = 0;
        var sPointer = 0;

        while(tPointer<t.Length && sPointer < s.Length)
        {
            if (s[sPointer] == t[tPointer])            
                sPointer++;
            
            tPointer++;
        }

        if (sPointer == s.Length)        
            return true;        
        else        
            return false;        
    }
}