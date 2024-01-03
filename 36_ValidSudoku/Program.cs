//https://leetcode.com/problems/valid-sudoku/description/

var sol = new Solution();

char[][] input =
[
    ['5', '3', '.', '.', '7', '.', '.', '.', '.'],
    ['6', '.', '.', '1', '9', '5', '.', '.', '.'],
    ['.', '9', '8', '.', '.', '.', '.', '6', '.'],
    ['8', '.', '.', '.', '6', '.', '.', '.', '3'],
    ['4', '.', '.', '8', '.', '3', '.', '.', '1'],
    ['7', '.', '.', '.', '2', '.', '.', '.', '6'],
    ['.', '6', '.', '.', '.', '.', '2', '8', '.'],
    ['.', '.', '.', '4', '1', '9', '.', '.', '5'],
    ['.', '.', '.', '.', '8', '.', '.', '7', '9'],
];

sol.IsValidSudoku(input); 
    

public class Solution
{
    public bool IsValidSudoku(char[][] board)
    {
        var rows = new Dictionary<int, HashSet<char>>();
        var cols = new Dictionary<int, HashSet<char>>();
        var squares = new Dictionary<(int, int), HashSet<char>>();

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

                var currentElement = board[r][c];
                
                if (currentElement == '.')
                    continue;

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