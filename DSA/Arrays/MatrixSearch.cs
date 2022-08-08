using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Arrays
{
    public class MatrixSearch
    {
        public static void Start()
        {
            int[][] mat = new int[][] {
                new int[] {1,2,3}, 
                new int[] {4,5,6},
                new int[] {7,8,9}
            };
            Console.WriteLine(SearchMatrix(mat, 1));
        }

        static bool SearchMatrix(int[][] matrix, int target) 
        {
            int m = matrix.Length;
            int n = matrix[0].Length;
            int l = 0;
            int h = (m*n)-1;
            while (l<=h)
            {
                int mid = (l+h)/2;
                int row = mid/n;
                int col = mid%n;
                if (matrix[row][col] == target)
                    return true;
                if (matrix[row][col] > target)
                    h = mid-1;
                else
                    l = mid+1;
            }
            return false;
        }
    }
}