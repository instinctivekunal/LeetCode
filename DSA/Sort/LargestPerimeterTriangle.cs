using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DSA_C.Sort
{
    public class LargestPerimeterTriangle
    {
        public static void Start()
        {
            int[] nums = {1,2,1};
            Console.WriteLine(LargestPerimeter(nums));
        }

        static int LargestPerimeter(int[] nums) 
        {
            Array.Sort(nums);
            for(int i=nums.Length-1; i>1; i--)
            {
                if(nums[i] < nums[i-1] + nums[i-2])
                    return nums[i] + nums[i-1] + nums[i-2];
            }
            return 0;
        }
    }
}