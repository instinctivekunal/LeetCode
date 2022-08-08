using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Search
{
    public class FourSumProblem
    {
        public static void Start()
        {
            int[] nums = {1000000000,1000000000,1000000000,1000000000};
            int target = -294967296;
            var ans = FourSum(nums, target);
        }

        static IList<IList<int>> FourSum(int[] nums, int target) 
        {
            var len = nums.Length;
            // Sort Array
            Array.Sort(nums);
            List<IList<int>> result = new List<IList<int>>();
            for (int first = 0; first < len; first++)
            {
                // If the current value is the same as the one before, skip it
                if (first > 0 && nums[first - 1] == nums[first]) continue;

                for (int second = first + 1; second < len; second++)
                {
                    // If the current value is the same as the one before, skip it
                    if (second > first + 1 && nums[second - 1] == nums[second]) continue;
                    int third = second + 1, fourth = len - 1;
                    while (third < fourth)
                    {
                        double sum = (double)nums[first] + (double)nums[second] + (double)nums[third] + (double)nums[fourth];
                        if (sum > target)
                            fourth--;
                        else if (sum < target)
                            third++;
                        else // if(sum==target)
                        {
                            result.Add(new List<int>() { nums[first], nums[second], nums[third++], nums[fourth--]});  
                            // Increment third when prv value is same to avoid duplicates in the result.                          
                            while (third < fourth && nums[third - 1] == nums[third]) third++;
                        }
                    }
                }
            }
            return result;
        }
    }
}