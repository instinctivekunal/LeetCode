using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Arrays
{
    public class RotateArray
    {
        public static void Start()
        {
            int[] nums = {1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16};
            int k = 0;
            Rotate(nums, k);
            Console.WriteLine(string.Join(",", nums));
        }

        static void Rotate1(int[] nums, int k) 
        {
            while (k>0) {
                int j = nums[nums.Length-1];
                for(int i=nums.Length-1; i>0 ; i--)
                {
                    nums[i] = nums[i-1];
                }
                nums[0]=j;
                k--;
            }
            Console.WriteLine(string.Join(",", nums));
        }

        static void Rotate(int[] nums, int k) 
        {
            k = k % nums.Length;
            Reverse(nums, 0, nums.Length-1);
            Reverse(nums, k, nums.Length-1);
            Reverse(nums, 0, k-1);
        }

        static void Reverse(int[] nums, int start, int end)
        {
            while(start<end)
            {
                int temp = nums[start];
                nums[start++] = nums[end];
                nums[end--] = temp;
            }
        }
    }
}