// https://leetcode.com/problems/range-sum-query-2d-immutable/description/

var sol = new NumMatrix(
    [
        [3, 0, 1, 4, 2],
        [5, 6, 3, 2, 1],
        [1, 2, 0, 1, 5],
        [4, 1, 0, 1, 7],
        [1, 0, 3, 0, 5]
    ]
);

// [2, 1, 4, 3], [1, 1, 2, 2], [1, 2, 2, 4]]
// sol.SumRegion(0, 1, 1, 2);


sol.SumRegion(2, 1, 4, 3);
// sol.SumRegion(1, 1, 2, 2);
// sol.SumRegion(1, 2, 2, 4);

public sealed class NumMatrix
{
    private readonly int[][] _sumMat;

    public NumMatrix(ReadOnlySpan<int[]> matrix)
    {
        int rows = matrix.Length;
        int cols = matrix[0].Length;
        _sumMat = new int[rows + 1][];

        for (int row = 0; row < _sumMat.Length; row++)
        {
            _sumMat[row] = new int[cols + 1];
        }


        for (int r = 0; r < rows; r++)
        {
            int prefix = 0;

            for (int c = 0; c < cols; c++)
            {
                prefix += matrix[r][c];
                int above = _sumMat[r][c + 1];
                _sumMat[r + 1][c + 1] = prefix + above;
            }
        }
    }

    public int SumRegion(int row1, int col1, int row2, int col2)
    {
        row1++;
        col1++;
        row2++;
        col2++;

        int bottomRight = _sumMat[row2][col2];
        int above = _sumMat[row1 - 1][col2];
        int left = _sumMat[row2][col1 - 1];
        int topLeft = _sumMat[row1 - 1][col1 - 1];

        return bottomRight - above - left + topLeft;
    }
}