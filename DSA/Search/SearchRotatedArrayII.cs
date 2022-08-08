using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Search
{
    public class SearchRotatedArrayII
    {
        public static void Start()
        {
            int[] nums = {2,5,6,0,0,1,2};
            int target = 0;
            Console.WriteLine(Search(nums, target));
        }

        static bool Search(int[] nums, int target) 
        {
            int res = SearchElement(nums, target);
            return res<0? false: true;
        }

        static int SearchElement(int[] nums, int target) 
        {
            int start = 0, end = nums.Length -1, mid =0;
            while (start<=end)            
            {
                if (nums[start] == target) return start;
                else if (nums[end] == target) return end;
                
                mid = start + (end-start)/2;
                Console.WriteLine("S->{0}..{1}..{2}",start, end, mid);
                if (nums[mid]==target)
                    return mid;

                if (target>nums[mid] && target<nums[end])
                    start=mid+1;
                else if(target<nums[mid] && target>nums[start])
                    end=mid-1;
                else{
                    start++;
                    end--;
                }
                Console.WriteLine("E->{0}..{1}..{2}",start, end, mid);
            }
            return -1;
        }
    }
}