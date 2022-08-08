using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Arrays
{
    public class HouseRobber
    {
        public static void Start()
        {
            int[] nums = {2,1,1,2};
            Console.WriteLine(Rob(nums));
        }

        static int Rob(int[] nums) 
        {
            int n = nums.Length;
            if (n==1) return nums[0];
            nums[1]=Math.Max(nums[0], nums[1]);
            if (n==2) return nums[1];
            
            for(int i=2; i<n; i++)
            {
                nums[i]=Math.Max(nums[i-1], nums[i-2]+nums[i]);
            }
            return nums[n-1];
        }
    }
}