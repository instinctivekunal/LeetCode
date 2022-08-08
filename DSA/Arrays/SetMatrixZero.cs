using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Arrays
{
    public class SetMatrixZero
    {
        public static void Start()
        {
            int[][] mat = new int[][] {
                new int[] {0,1,2,0}, 
                new int[] {3,4,5,2},
                new int[] {1,3,1,5}
            };
            SetZeroes1(mat);
            for(int i=0; i<mat.Length; i++)
            {
                Console.WriteLine(string.Join(",", mat[i]));
            }
        }

        static void SetZeroes1(int[][] matrix) 
        {
            int m = matrix.Length;
            int n = matrix[0].Length;
            bool rowZero = false, colZero = false;
            for (int i=0; i<m; i++)
            {
                for (int j=0; j<n; j++)
                {
                    if (matrix[i][j]==0)
                    {
                        if(i==0) {rowZero = true;}
                        if(j==0) {colZero = true;}
                        matrix[i][0]=0;
                        matrix[0][j]=0;
                    }
                }
            }            
            for (int i=1; i<m; i++)
            {
                for (int j=1; j<n; j++)
                {
                    if (matrix[i][0]==0 || matrix[0][j]==0)
                    {
                        matrix[i][j]=0;
                    }
                }
            }
            if (rowZero)
            {
                for (int j=0; j<n; j++)
                {
                    matrix[0][j] = 0;
                }
            }
            if(colZero)
            {
                for (int i=0; i<m; i++)
                {
                    matrix[i][0] = 0;
                }
            }
        }

        static void SetZeroes(int[][] matrix) 
        {
            int m = matrix.Length;
            int n = matrix[0].Length;
            HashSet<int> rows = new HashSet<int>();
            HashSet<int> cols = new HashSet<int>();
            for (int i=0; i<m; i++)
            {
                for (int j=0; j<n; j++)
                {
                    if (matrix[i][j]==0)
                    {
                        if(!rows.Contains(i))
                            rows.Add(i);
                        if(!cols.Contains(j))
                            cols.Add(j);
                    }
                }
            }
            for (int i=0; i<m; i++)
            {
                for (int j=0; j<n; j++)
                {
                    if (rows.Contains(i) || cols.Contains(j))
                    {
                        matrix[i][j]=0;
                    }
                }
            }
        }
    }
}