using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Arrays
{
    public class TargetArray
    {
        public static void Start()
        {
            int[] nums1 = {0,1,2,3,4};
            int[] nums2 = {0,1,2,2,1};
            Console.WriteLine(string.Join(",", CreateTargetArray(nums1, nums2)));
        }

        static int[] CreateTargetArray(int[] nums, int[] index) 
        {
            int[] res = new int[nums.Length];
            for (int i=0; i<nums.Length; i++)
            {
                int idx = index[i];
                if(idx < i)
                {
                    for(int j=i; j>idx; j--)
                        res[j] = res[j-1];
                }
                res[idx] = nums[i];
            }
            return res;
        }
    }
}