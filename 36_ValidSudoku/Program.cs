// https://leetcode.com/problems/valid-sudoku/description/

public class Solution
{
    public bool IsValidSudoku(char[][] board)
    {
        Dictionary<int, HashSet<char>> rows = [];
        Dictionary<int, HashSet<char>> cols = [];
        Dictionary<(int, int), HashSet<char>> squares = [];

        for (var r = 0; r < 9; r++)
        {
            for (var c = 0; c < 9; c++)
            {
                #region Initial subcollection init

                if (!rows.ContainsKey(r))
                    rows[r] = [];

                if (!cols.ContainsKey(c))
                    cols[c] = [];

                if (!squares.ContainsKey((r / 3, c / 3)))
                    squares[(r / 3, c / 3)] = [];

                #endregion

                #region Get Current Element

                var currentElement = board[r][c];

                if (currentElement == '.')
                    continue;

                #endregion

                #region Valid Sudoku Checks

                //Check if current element exist in row dictionary column dictionary or squeres dictionary if yes then this is not valid sudoku
                if (rows[r].Contains(currentElement))
                    return false;

                if (squares[(r / 3, c / 3)].Contains(currentElement))
                    return false;

                if (cols[c].Contains(currentElement))
                    return false;

                #endregion

                #region Add current element to sub collections

                rows[r].Add(currentElement);

                cols[c].Add(currentElement);

                squares[(r / 3, c / 3)].Add(currentElement);

                #endregion
            }
        }

        return true;
    }
}