using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Search
{
    public class SearchInsertPosition
    {
        public static void Start()
        {
            int[] nums = {1,3,5,6};
            int target = 5;
            Console.WriteLine(SearchInsert(nums, target));
        }

        static int SearchInsert(int[] nums, int target) 
        {
            int start=0, end=nums.Length-1, mid=0;
            while(start<=end)
            {                
                mid = start + (end-start)/2;
                Console.WriteLine("S->{0}..{1}..{2}..{3}",start, end, mid, target);
                if (target == nums[mid])
                    return mid;
                if (target < nums[mid])
                    end = mid-1;
                else
                    start = mid+1;
                Console.WriteLine("E->{0}..{1}..{2}..{3}",start, end, mid, target);
            }
            return start;
        }
    }
}