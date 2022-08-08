using System.Collections;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Arrays
{
    public class TwoSum
    {
        public static void Start()
        {
            int[] nums = {3,2,4};
            int target = 6;
            Console.WriteLine(string.Join(",", TwoSumMethod(nums, target)));
        }

        static int[] TwoSumMethod(int[] nums, int target) 
        {
            Dictionary<int, int> data = new Dictionary<int, int>();
            int[] ans = new int[2];
            for(int i=0; i<nums.Length; i++)
            {
                if (data.ContainsValue(target - nums[i]))
                {
                    ans[0] = data.First(x => x.Value == (target - nums[i])).Key;
                    ans[1] = i;
                    break;
                }
                data.Add(i, nums[i]);                
            }
            return ans;
        }
    }
}