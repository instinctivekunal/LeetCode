namespace DSA_C.Recursion
{
    public class NQueens
    {
        // https://leetcode.com/problems/n-queens/
        public void Start()
        {
            int n = 4;
            Console.WriteLine(SolveNQueens(n));
        }

         IList<IList<string>> SolveNQueens(int n) {
            string [,] board = new string[n,n];
            IList<IList<string>> ans = new List<IList<string>> ();
            for(int i=0; i<n; i++)
                for(int j=0; j<n; j++)
                    board[i,j] = ".";
            NQueen(board, 0, ans);
            return ans;
        }

         void NQueen(string[,] board, int row, IList<IList<string>> ans)
        {
            if(row == board.GetLength(0))
            {
                ans.Add(contruct(board));
                return;
            }

            for(int col=0; col<board.GetLength(1); col++)
            {
                if (IsSafe(board, row, col))
                {
                    board[row, col] = "Q";
                    NQueen(board, row+1, ans);
                    board[row, col] = ".";
                }
            }
        }

         List<string> contruct(string[,] board)
        {
            List<string> res = new List<string>();
            for(int i=0; i<board.GetLength(0); i++)
            {
                string s = "";
                for(int j=0; j<board.GetLength(1); j++)
                    s+=board[i,j];
                res.Add(s);
            }
            return res;
        }

         bool IsSafe(string[,] board, int row, int col)
        {
            // Check vertical row
            for (int i=0; i<row; i++)
                if (board[i,col] == "Q")
                    return false;

            // Check Diagonal left
            int r = row, c = col;
            while (r>=0 && c>=0)
                if(board[r--,c--] == "Q")
                    return false;
            
            // Check Diagonal Right
            r = row;
            c = col;
            while (r>=0 && c<board.GetLength(1))
                if(board[r--,c++] == "Q")
                    return false;
            return true;
        }
    }
}