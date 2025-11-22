https://leetcode.com/problems/assign-cookies/

public class Solution
{
    public int FindContentChildren(int[] g, int[] s)
    {
        Array.Sort(g);
        Array.Sort(s);
        int contentChild = 0;

        for (int cookie = 0; contentChild < g.Length && cookie < s.Length; cookie++)
        {
            if (g[contentChild] <= s[cookie])
            {
                contentChild++;
            }
        }

        return contentChild;

    }
}
