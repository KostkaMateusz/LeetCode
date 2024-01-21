//https://leetcode.com/problems/valid-perfect-square/

var sol = new Solution();

bool ans;

ans = sol.IsPerfectSquare(16);
Console.WriteLine(ans);

ans = sol.IsPerfectSquare(14);
Console.WriteLine(ans);

ans = sol.IsPerfectSquare(1);
Console.WriteLine(ans);

ans = sol.IsPerfectSquare(9);
Console.WriteLine(ans);


public class Solution
{
    public bool IsPerfectSquare(int num)
    {
        if (num == 1)
            return true;

        long left = 0;
        long right = num / 2;

        while (left <= right)
        {
            long mid = left + (right - left) / 2;
            long midSquare = mid * mid;

            if (midSquare > num)
                right = mid - 1;
            else if (midSquare < num)
                left = mid + 1;
            else
                return true;
        }
        return false;
    }
}