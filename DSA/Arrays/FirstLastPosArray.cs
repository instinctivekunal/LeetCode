using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Arrays
{
    public class FirstLastPosArray
    {
        public static void Start()
        {
            int[] nums = {5,7,7,8,8,10};
            int target = 9;
            Console.WriteLine(string.Join(",", SearchRange(nums, target)));
        }

        static int[] SearchRange(int[] nums, int target) 
        {
            int idx = BinarySearch(nums, target);
            if (idx < 0)
                return new int[] {-1,-1};

            int left = idx;
            int right = idx;
            while ((left-1) >= 0 && nums[left] == nums[left-1])
                left--;
            while ((right+1) < nums.Length && nums[right] == nums[right+1])
                right++;
            return new int[] {left, right};
        }

        static int BinarySearch(int[] nums, int target)
        {
            int start = 0;
            int end = nums.Length-1;
            while (start <= end)
            {
                int mid = (start + end)/2;
                if (nums[mid] == target)
                {  
                    return mid;
                }
                else if (nums[mid] < target)
                    start = mid + 1;
                else
                    end = mid - 1;
            }
            return -1;
        }
    }
}