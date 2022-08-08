using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Arrays
{
    public class BuildFromPermutation
    {
        public static void Start()
        {
            int[] nums = {0,2,1,5,3,4};
            Console.WriteLine(string.Join(",", BuildArray(nums)));
        }
        
        static int[] BuildArray(int[] nums) 
        {
            int[] ans = new int[nums.Length];
            for (int i=0; i<nums.Length; i++)
            {
                ans[i] = nums[nums[i]];
            }
            return ans;
        }

    }
}