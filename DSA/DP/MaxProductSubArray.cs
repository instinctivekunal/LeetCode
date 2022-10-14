namespace DSA_C.DP
{
    public class MaxProductSubArray
    {
        // https://leetcode.com/problems/maximum-product-subarray/
        public void Start()
        {
            int[] nums = {-2,3,-4};
            Console.WriteLine(MaxProduct(nums));
        }

        int MaxProduct(int[] nums) {
            int res = nums.Max();
            int curMax = 1, curMin = 1;
            foreach (int num in nums)
            {
                if (num == 0) {
                    curMax = curMin = 1;
                }
                int temp = curMax;
                curMax = Math.Max(num, Math.Max(curMax * num, curMin * num));
                curMin = Math.Min(num, Math.Min(curMin * num, temp * num));
                res = Math.Max(res, curMax);
                
            }
            return res;
        }        
    }
}