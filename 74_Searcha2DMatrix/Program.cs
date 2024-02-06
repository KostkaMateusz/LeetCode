// https://leetcode.com/problems/search-a-2d-matrix/

var sol = new Solution();

var ans = sol.SearchMatrix([[1, 3, 5, 7], [10, 11, 16, 20], [23, 30, 34, 60]], 16);
Console.WriteLine(ans);

public class Solution
{
    public bool SearchMatrix(int[][] matrix, int target)
    {
        var top = 0;
        var bot = matrix.Length - 1;
        var row = 0;

        var columnsNumber = matrix[0].Length - 1;

        while (top <= bot)
        {
            row = (bot + top) / 2;

            if (matrix[row][columnsNumber] < target)
                top = row + 1;
            else if (matrix[row][0] > target)
                bot = row - 1;
            else
                break;
        }

        if (top > bot)
            return false;

        var left = 0;
        var right = matrix[0].Length - 1;

        while (left <= right)
        {
            var column = (right + left) / 2;

            if (matrix[row][column] < target)
                left = column + 1;
            else if (matrix[row][column] > target)
                right = column - 1;
            else
                return true;
        }

        return false;
    }
}