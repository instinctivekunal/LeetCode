using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Search
{
    public class SpecialArrayX
    {
        public static void Start()
        {
            int[] arr = {0,4,3,0,4};
            Console.WriteLine(SpecialArray(arr));
        }

        static int SpecialArray(int[] nums) 
        {
            int mid=0;
            int start=0, end=nums.Length;
            while(start<=end)
            {
                mid = start + (end-start)/2;
                int target = nums.Count(i => i >= mid);
                if (mid == target)
                    return mid;
                if (mid < target)
                    start=mid+1;
                else
                    end=mid-1;
            }
            return -1;
        }

        static int SpecialArray1(int[] nums) 
        {
            Array.Sort(nums);
            int ans=0;
            for (int i=nums.Length -1; i>=0; i--)
            {
                if (nums[i] == ans)
                    return -1;
                if (nums[i] < ans)
                    return ans;
                ans++;
            }
            return ans;
        }
    }
}