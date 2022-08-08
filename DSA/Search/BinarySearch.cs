using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Search
{
    public class BinarySearch
    {
        public static void Start()
        {
            int[] arr = {-1,0,3,5,9,12};
            Console.WriteLine(Search(arr, 2));
        }

        static int Search(int[] nums, int target) 
        {
            int mid=0;
            int start=0, end=nums.Length-1;
            while(start<=end)
            {
                mid = start + (end-start)/2;
                if (nums[mid] == target)
                    return mid;
                if (nums[mid] < target)
                    start=mid+1;
                else
                    end=mid-1;
            }
            return -1;
        }
    }
}