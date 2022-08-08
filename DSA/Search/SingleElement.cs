using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Search
{
    public class SingleElement
    {
        public static void Start()
        {
            int[] nums = {1,2,2,3,3,4,4,8,8};
            Console.WriteLine(SingleNonDuplicate(nums));
        }

        static int SingleNonDuplicate(int[] nums) 
        {
            int mid=0;
            int start=0, end=nums.Length-1;
            while(start<end)
            {
                mid = start + (end-start)/2;
                Console.WriteLine("S->{0}..{1}..{2}",start, end, mid);
                if ((mid==0 && nums[mid]!=nums[mid+1]) ||
                    (mid==end && nums[mid]!=nums[mid-1]) ||
                    (nums[mid]!=nums[mid+1] && nums[mid]!=nums[mid-1]))
                    return nums[mid];

                bool isEven = (mid & 1) == 0;
                if ((isEven && nums[mid] == nums[mid+1]) || (!isEven && nums[mid] == nums[mid-1]))
                    start=mid+1;
                else
                    end=mid;
                Console.WriteLine("E->{0}..{1}..{2}",start, end, mid);
            }
            return nums[start];
        }

        static int SingleNonDuplicate1(int[] nums) 
        {
            for(int i=0; i<nums.Length-1; i+=2)
            {
                if (nums[i] != nums[i+1])
                    return nums[i];                    
            }
            return nums[nums.Length-1];
        }        
    }
}