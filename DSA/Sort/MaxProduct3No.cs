using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DSA_C.Sort
{
    public class MaxProduct3No
    {
        public static void Start()
        {
            int[] nums = {-100,-98,-1,2,3,4};
            Console.WriteLine(MaximumProduct(nums));
        }

        static int MaximumProduct(int[] nums) 
        {
            Array.Sort(nums);
            return Math.Max(nums[^1] * nums[^2] * nums[^3], nums[0] * nums[1] * nums[^1]);
        }
    }
}