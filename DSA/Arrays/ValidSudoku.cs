using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Arrays
{
    public class ValidSudoku
    {
        public static void Start()
        {
            char[][] board = new char[][] {
                new char[] {'8','3','.','.','7','.','.','.','.'},
                new char[] {'6','.','.','1','9','5','.','.','.'},
                new char[] {'.','9','8','.','.','.','.','6','.'},
                new char[] {'8','.','.','.','6','.','.','.','3'},
                new char[] {'4','.','.','8','.','3','.','.','1'},
                new char[] {'7','.','.','.','2','.','.','.','6'},
                new char[] {'.','6','.','.','.','.','2','8','.'},
                new char[] {'.','.','.','4','1','9','.','.','5'},
                new char[] {'.','.','.','.','8','.','.','7','9'}
            };
            Console.WriteLine(IsValidSudoku(board));
        }

        static bool IsValidSudoku(char[][] board) 
        {
            for(int r=0; r<board.Length; r++)
            {
                for(int c=0; c<board[0].Length; c++)
                {
                    if (!IsValid(board, r, c))
                        return false;
                }
            }
            return true;
        }

        static bool IsValid(char[][] board, int r, int c)
        {
            return NotInRow(board, r) && NotInCol(board, c) && NotInBox(board, r-r%3, c-c%3);
        }

        static bool NotInRow(char[][] board, int r)
        {
            HashSet<char> res = new HashSet<char>();
            for(int i=0; i<9; i++)
            {
                char curr = board[r][i];
                if (res.Contains(curr))
                    return false;
                if (curr != '.')
                    res.Add(curr);
            }
            return true;
        }

        static bool NotInCol(char[][] board, int c)
        {
            HashSet<char> res = new HashSet<char>();
            for(int i=0; i<9; i++)
            {
                char curr = board[i][c];
                if (res.Contains(curr))
                    return false;
                if (curr != '.')
                    res.Add(curr);
            }
            return true;
        }

        static bool NotInBox(char[][] board, int r, int c)
        {
            HashSet<char> res = new HashSet<char>();
            for(int i=0; i<3; i++)
            {
                for(int j=0; j<3; j++)
                {
                    char curr = board[i+r][j+c];
                    if (res.Contains(curr))
                        return false;
                    if (curr != '.')
                        res.Add(curr);
                }                
            }
            return true;
        }
    }
}