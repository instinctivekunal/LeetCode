using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Search
{
    public class DuplicateNumber
    {
        public static void Start()
        {
            int[] nums = {1,3,4,2,2};
            Console.WriteLine(FindDuplicate(nums));
        }

        static int FindDuplicate(int[] nums) {
            int i=0;
            while(i<nums.Length)
            {
                if(nums[i] != i+1)
                {
                    int correct = nums[i]-1;
                    Console.WriteLine(correct);
                    if (nums[i] != nums[correct])
                        Swap(nums, i, correct);
                    else
                        return nums[i];
                }
                else
                    i++;
                Console.WriteLine(string.Join("\t", nums));
                Console.WriteLine("i={0}",i);
            }
            return -1;
        }

        static void Swap(int[] arr, int first, int second)
        {
            int t = arr[first];
            arr[first] = arr[second];
            arr[second] = t;
        }
    }
}