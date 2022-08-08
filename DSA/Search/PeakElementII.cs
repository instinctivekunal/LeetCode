using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Search
{
    public class PeakElementII
    {
        public static void Start()
        {
            int[][] mat = new int[][] {
                new int[] {41,8,2,48,18}, 
                new int[] {16,15,9,7,44},
                new int[] {48,35,6,38,28},
                new int[] {3,2,14,15,33},
                new int[] {39,36,13,46,42}
            };
            Console.WriteLine(string.Join(",", FindPeakGrid(mat)));            
        }

        static int[] FindPeakGrid(int[][] mat) 
        {
            int start=0, end=mat[0].Length-1, mid=0;
            while(start<=end)
            {
                int maxRow=0;
                mid=start+(end-start)/2;
                Console.WriteLine("S->{0}..{1}..{2}..{3}",start, end, mid, maxRow);
                for(int row=0; row<mat.Length; row++)
                {
                    maxRow = (mat[row][mid]>=mat[maxRow][mid])?row:maxRow;
                }
                Console.WriteLine(maxRow);
                bool isLeft = mid-1>=start && mat[maxRow][mid-1] > mat[maxRow][mid];
                bool isRight = mid+1<=end && mat[maxRow][mid+1] > mat[maxRow][mid];

                if(!isLeft && !isRight)
                    return new int[]{maxRow, mid};
                else if(isLeft)
                    end = mid-1;
                else
                    start = mid+1;
                Console.WriteLine("E->{0}..{1}..{2}..{3}",start, end, mid, maxRow);
            }
            return new int[] {-1,-1};
        }
    }
}