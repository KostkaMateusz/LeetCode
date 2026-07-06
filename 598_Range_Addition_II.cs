// https://leetcode.com/problems/range-addition-ii/description/


var sol = new Solution();

sol.MaxCount(m: 3, n: 3, ops: [[2, 2], [3, 3]]);
sol.MaxCount(m: 40000, n: 40000, ops: []);


public class Solution
{
    public int MaxCount(int m, int n, int[][] ops)
    {

        int minRow = m;
        int minCol = n;

        foreach (var o in ops)
        {
            minRow=Math.Min(minRow,o[0]);
            minCol=Math.Min(minCol,o[1]);
        }


        return minRow*minCol;

    }
}

