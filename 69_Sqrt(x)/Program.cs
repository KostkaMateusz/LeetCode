//https://leetcode.com/problems/sqrtx/

var sol = new Solution();

int ans;

ans=sol.MySqrt(0);
Console.WriteLine(ans);

ans = sol.MySqrt(1);
Console.WriteLine(ans);

ans = sol.MySqrt(2);
Console.WriteLine(ans);

ans = sol.MySqrt(3);
Console.WriteLine(ans);

ans = sol.MySqrt(4);
Console.WriteLine(ans);

ans = sol.MySqrt(5);
Console.WriteLine(ans);

ans = sol.MySqrt(6);
Console.WriteLine(ans);

public class Solution
{
    public int MySqrt(int x)
    {
        int left = 0; 
        int right = x;

        while (left <= right)
        {
            long mid = (left + right) / 2; 
            long midSquare = mid * mid;

            if (x == midSquare)
                return (int)mid;
            else if (midSquare > x)
                right = (int)(mid - 1);
            else if(midSquare < x)
                left = (int)(mid + 1);
        }
        return right;
    }
}