// https://leetcode.com/problems/pascals-triangle-ii/description/

public class Solution
{
    public IList<int> GetRow(int rowIndex)
    {
        int[] prevRow = [1];

        for (int i = 1; i <= rowIndex; i++)
        {
            var row = new int[i + 1];
            row[0] = 1;
            row[^1] = 1;


            for (int j = 1; j < row.Length - 1; j++)
            {
                row[j] = prevRow[j - 1] + prevRow[j];
            }

            prevRow = row;
        }

        return prevRow;
    }
}
