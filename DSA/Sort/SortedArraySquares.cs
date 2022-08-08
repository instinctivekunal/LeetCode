using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DSA_C.Sort
{
    public class SortedArraySquares
    {
        public static void Start()
        {
            int[] nums = {-4,-1,0,3,10};
            Console.WriteLine(string.Join(",", SortedSquares(nums)));
        }

        static int[] SortedSquares(int[] nums) 
        {
            int n=nums.Length;
            int l=0, r=n-1;
            int[] ans = new int[n];
            for(int m=n-1; m>=0; m--)
            {
                if(Math.Abs(nums[l]) > Math.Abs(nums[r]))
                {
                    ans[m] = nums[l]*nums[l];
                    l++;
                }
                else{
                    ans[m] = nums[r]*nums[r];
                    r--;
                }
            }
            return ans;
        }
    }
}