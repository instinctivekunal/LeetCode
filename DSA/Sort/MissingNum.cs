using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DSA_C.Sort
{
    public class MissingNum
    {
        public static void Start()
        {
            int[] nums = {0,1};
            Console.WriteLine(MissingNumber(nums));
        }

        static int MissingNumber(int[] nums) {
            Array.Sort(nums);
            for(int i=0; i<nums.Length; i++)
            {
                if(nums[i] != i) return i;
            }
            return nums.Length;
        }
    }
}