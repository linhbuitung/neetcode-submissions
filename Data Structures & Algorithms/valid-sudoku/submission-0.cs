public class Solution {
    public bool IsValidSudoku(char[][] board) {
        for (int i = 0; i < 9; i++)
        {
            var row = new int[9];
            var col = new int[9];

            for (int j = 0; j < 9; j++)
            {
                // row check
                if (board[i][j] != '.')
                {
                    int idx = board[i][j] - '1';
                    row[idx]++;
                    if (row[idx] > 1) return false;
                }

                // col check
                if (board[j][i] != '.')
                {
                    int idx = board[j][i] - '1';
                    col[idx]++;
                    if (col[idx] > 1) return false;
                }
            }
        }

        for (int box = 0; box < 9; box++)
        {
            var square = new int[9];
            int rowStart = (box / 3) * 3;
            int colStart = (box % 3) * 3;

            for (int r = rowStart; r < rowStart + 3; r++)
            {
                for (int c = colStart; c < colStart + 3; c++)
                {
                    if (board[r][c] != '.')
                    {
                        int idx = board[r][c] - '1';
                        square[idx]++;
                        if (square[idx] > 1) return false;
                    }
                }
            }
        }

        return true;
    }
}
