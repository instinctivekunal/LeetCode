using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Arrays
{
    public class RowCol2DMatrix
    {
        public static void Start()
        {
            int[][] mat = new int[][] {
                new int[] {1,4,7,11,15}, 
                new int[] {2,5,8,12,19},
                new int[] {3,6,9,16,22},
                new int[] {10,13,14,17,24},
                new int[] {18,21,23,26,30}
            };
            Console.WriteLine(SearchMatrix(mat, 55));
        }

        static bool SearchMatrix(int[][] matrix, int target) 
        {
            int r = 0;
            int c = matrix[0].Length-1;
            while (r < matrix.Length && c>=0)
            {
                if (matrix[r][c] == target)
                    return true;
                if (matrix[r][c] < target)
                    r++;
                else
                    c--;
            }
            return false;
        }
    }
}