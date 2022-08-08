using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Arrays
{
    public class SortColors
    {
        public static void Start()
        {
            int[] nums = {2,0,2,0,1,0,1,2,1};
            Sort(nums);
            Console.WriteLine(string.Join(",", nums));
        }

        static void Sort(int[] nums) 
        {
            for(int i=0; i<nums.Length-1; i++)
            {
                for(int j=i+1; j>0; j--)
                {
                    if (nums[j]<nums[j-1])
                        Swap(nums, j, j-1);
                    else
                        break;
                }
            }
        }

        static void Swap(int[] nums, int first, int second)
        {
            int t = nums[first];
            nums[first] = nums[second];
            nums[second] = t;
        }
    }
}