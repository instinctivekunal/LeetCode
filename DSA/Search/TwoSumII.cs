using System.Collections;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Arrays
{
    public class TwoSumII
    {
        public static void Start()
        {
            int[] nums = {2,3,4};
            int target = 6;
            Console.WriteLine(string.Join(",", TwoSum(nums, target)));
        }

        static int[] TwoSumPointer(int[] numbers, int target)
        {
            int left=0, right=numbers.Length-1;
            while(left<right)
            {
                if(numbers[left] + numbers[right] == target)
                    return new int[] {left+1, right+1};
                if(numbers[left] + numbers[right] < target) left++;
                if(numbers[left] + numbers[right] > target) right--;
            }
            return new int[2];
        }

        static int[] TwoSum(int[] numbers, int target) 
        {
           int n = numbers.Length;
           for (int i=0; i<n; i++)
           {
                int no = target - numbers[i];
                int idx = BinarySearch(numbers, no, i+1, n-1);
                if (idx > 0)
                    return new int[] {i+1, idx+1};
           }
           return new int[2];
        }

        static int BinarySearch(int[] nums, int target, int start, int end)
        {
            int mid=0;
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