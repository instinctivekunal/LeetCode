namespace DSA_C.Recursion
{
    public class SudokuSolver
    {
        // https://leetcode.com/problems/sudoku-solver/
        public void Start()
        {
            char[][] board = new char[9][] {
                new char[] {'5','3','.','.','7','.','.','.','.'},
                new char[] {'6','.','.','1','9','5','.','.','.'},
                new char[] {'.','9','8','.','.','.','.','6','.'},
                new char[] {'8','.','.','.','6','.','.','.','3'},
                new char[] {'4','.','.','8','.','3','.','.','1'},
                new char[] {'7','.','.','.','2','.','.','.','6'},
                new char[] {'.','6','.','.','.','.','2','8','.'},
                new char[] {'.','.','.','4','1','9','.','.','5'},
                new char[] {'.','.','.','.','8','.','.','7','9'}
            };

            SolveSudoku(board);
        }

         void SolveSudoku(char[][] board) 
        {
            Solve(board);
        }

         bool Solve(char[][] board) 
        {
            for (int i=0; i<board.Length; i++)
            {
                for (int j=0; j<board[i].Length; j++)
                {
                    if (board[i][j] == '.')
                    {
                        for(char c='1'; c<='9'; c++)
                        {
                            if(IsSafe(board, i, j, c))
                            {
                                board[i][j] = c;
                                if (Solve(board)) 
                                    return true;
                                else 
                                    board[i][j] = '.';
                            }
                        }
                        return false;
                    }
                }
            }
            return true;
        }

         bool IsSafe(char[][] board, int row, int col, char ch)
        {
            for (int i=0; i<board.Length; i++)
            {
                if (board[row][i] == ch) return false;
                if (board[i][col] == ch) return false;                
            }
            int sqrt = (int)Math.Sqrt(board.Length);
            int rowStart = row - row % sqrt;
            int colStart = col - col % sqrt;
            for (int r=rowStart; r<rowStart+sqrt; r++)
                for (int c=colStart; c<colStart+sqrt; c++)
                    if(board[r][c] == ch) return false;

            return true;
        }
    }
}