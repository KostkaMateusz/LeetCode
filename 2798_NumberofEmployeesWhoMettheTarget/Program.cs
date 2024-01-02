//https://leetcode.com/problems/number-of-employees-who-met-the-target/description/
public class Solution
{
    public int NumberOfEmployeesWhoMetTarget(int[] hours, int target)
    {
        int meet = 0;
        foreach(int hour in hours)
        {
            if (hour >= target)
            {
                meet++;
            }
        }
        return meet;
    }
}