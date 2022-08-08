using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Arrays
{
    //Not Solved
    public class SpiralMatrix3
    {
        public static void Start()
        {
            var mat = SpiralMatrixIII(5,6,1,4);
            foreach(int[] row in mat)
                Console.WriteLine(string.Join("\t", row));
        }
        
        static int[][] SpiralMatrixIII(int rows, int cols, int rStart, int cStart)
        {
            var ans = new int[rows][];
            int top = rStart;
            int bottom = rows-1;
            int left = cStart;
            int right = cols-1;
            int digit = 1;
            int count = rows*cols;

            for (var q=0; q<rows; q++) 
                ans[q] = new int[cols];
            
            while (digit<=count)
            {
                Console.WriteLine("{0}..{1}..{2}..{3}", left, top, right, bottom);
                for (int i=left; i<=right; i++)
                    ans[top][i] = digit++;
                top++;
                Console.WriteLine("{0}..{1}..{2}..{3}", left, top, right, bottom);
                for (int i=top; i<=bottom; i++)
                    ans[i][right] = digit++;
                right--;
                Console.WriteLine("{0}..{1}..{2}..{3}", left, top, right, bottom);
                for (int i=right; i>=left; i--)
                    ans[bottom][i] = digit++;
                bottom--;
                Console.WriteLine("{0}..{1}..{2}..{3}", left, top, right, bottom);
                for (int i=bottom; i>=top; i--)
                    ans[i][left] = digit++;
                left++;
                Console.WriteLine("{0}..{1}..{2}..{3}", left, top, right, bottom);
                break;
            }
            return ans;         
        }
    }
}