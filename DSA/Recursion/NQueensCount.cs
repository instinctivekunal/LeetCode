namespace DSA_C.Recursion
{
    public class NQueensCount
    {
        // https://leetcode.com/problems/n-queens-ii/
        public void Start()
        {
            int n = 4;
            Console.WriteLine(TotalNQueens(n));
        }

         int TotalNQueens(int n) {
            string [,] board = new string[n,n];
            IList<IList<string>> ans = new List<IList<string>> ();
            for(int i=0; i<n; i++)
                for(int j=0; j<n; j++)
                    board[i,j] = ".";
            return NQueen(board, 0);
        }

         int NQueen(string[,] board, int row)
        {
            if(row == board.GetLength(0))
            {                
                return 1;
            }
            int count = 0;

            for(int col=0; col<board.GetLength(1); col++)
            {
                if (IsSafe(board, row, col))
                {
                    board[row, col] = "Q";
                    count += NQueen(board, row+1);
                    board[row, col] = ".";
                }
            }
            return count;
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
    }
}