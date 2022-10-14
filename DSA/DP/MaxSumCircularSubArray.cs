namespace DSA_C.DP
{
    // https://leetcode.com/problems/maximum-sum-circular-subarray/
    public class MaxSumCircularSubArray
    {
        public void Start()
        {
            int[] nums = {3,4,2};        
            Console.WriteLine(MaxSubarraySumCircular(nums));
        }

        int MaxSubarraySumCircular(int[] nums) {
            int sum=0;
            int currMin=0;
            int currMax=0;
            int min=nums[0];
            int max=nums[0];

            for (int i=0; i<nums.Length; i++)
            {
                sum+=nums[i];
                currMax = Math.Max(currMax+nums[i], nums[i]);
                max = Math.Max(max, currMax);
                currMin = Math.Min(currMin+nums[i], nums[i]);
                min = Math.Min(min, currMin);
            }
            return max>0 ? Math.Max(max, sum-min) : max;
        }
    }

    
}