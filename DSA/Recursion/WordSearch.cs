namespace DSA_C.Recursion
{
    public class WordSearch
    {
        public void Start()
        {
            char[][] board = new char[][] {
                new char[] {'A', 'B', 'C', 'E'},
                new char[] {'S', 'F', 'C', 'S'},
                new char[] {'A', 'D', 'E', 'E'}
            };
            string word = "ABCB";
            Console.WriteLine(Exist(board, word));
        }

         bool Exist(char[][] board, string word)
        {
            for (int i=0; i<board.Length; i++)
            {
                for (int j=0; j<board[0].Length; j++)
                {
                    if (board[i][j] == word[0] && Search(board, i, j, 0, word))
                        return true;
                }
            }
            return false;
        }

         bool Search(char[][] board, int i, int j, int count, string word)
        {
            if (count == word.Length) return true;
            if (i<0 || j<0 || i>=board.Length || j>=board[i].Length || board[i][j] != word[count])
                return false;
            
            char temp = board[i][j];
            board[i][j] = '*';
            if (Search(board, i-1, j, count+1, word) 
            || Search(board, i+1, j, count+1, word)
            || Search(board, i, j-1, count+1, word)
            || Search(board, i, j+1, count+1, word))
                return true;
            board[i][j] = temp;
            return false;
        }
    }
}