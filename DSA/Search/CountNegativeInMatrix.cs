using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Search
{
    public class CountNegativeInMatrix
    {
        public static void Start()
        {
            int[][] grid = new int[][] {
                new int[] {4,3,2,-1},
                new int[] {3,2,1,-1},
                new int[] {1,2,-1,-2},
                new int[] {-1,-1,-2,-3}
            };
            Console.WriteLine(CountNegatives(grid));
        }

        static int CountNegatives(int[][] grid) 
        {
            int count = 0;
            int end=grid[0].Length;            
            for(int i=0; i<grid.Length; i++)
            {
                int start=0;
                while(start<end)
                {
                    int mid = start +(end-start)/2;
                    if(grid[i][mid] >= 0)
                        start = mid+1;
                    else
                        end=mid;                    
                }
                count += (grid[0].Length-end);
            }
            return count;
        }

        static int CountNegatives1(int[][] grid) 
        {
            int count = 0;
            for(int i=0; i<grid.Length; i++)
            {
                for(int j=0; j<grid[i].Length; j++)
                {
                    if(grid[i][j] < 0) {
                        count+=grid[i].Length-j;
                        break;
                    }
                }
            }
            return count;
        }
    }
}