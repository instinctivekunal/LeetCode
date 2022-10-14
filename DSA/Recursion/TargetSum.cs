namespace DSA_C.Recursion
{
    public class TargetSum
    {
        //https://leetcode.com/problems/target-sum/
        public void Start()
        {
            int[] nums = {1,1,1,1,1};
            int target = 3;
            Console.WriteLine(FindTargetSumWays(nums, target));
        }

        int FindTargetSumWays(int[] nums, int target) 
        {
            // S1-S2 = D ~ S2 = (TotalSum - D)/2 -> D=target, S1&S2 = Subset
            int n=nums.Length;
            int total=0;
            foreach(int no in nums)
                total+=no;
            
            if (total-target < 0) return 0;
            if ((total-target) %2 == 1) return 0;

            int res = (total-target)/2;
            int[,] dp = new int[n, res+1];
            for(int i=0; i<n*(res+1); i++)
                dp[i%n, i/n] = -1;
            
            return CountWays(nums, res, n-1, dp);
        }

        int CountWays(int[] nums, int target, int idx, int[,] dp)
        {
            if (idx == 0)
            {
                if (target == 0 && nums[0] == 0) return 2;
                if (target == 0 || target == nums[0]) return 1;
                return 0;
            }
            
            //Memoization
            if (dp[idx,target] != -1) return dp[idx,target];

            int notTaken = CountWays(nums, target, idx-1, dp);
            int taken = 0;
            if (nums[idx] <= target)
                taken = CountWays(nums, target-nums[idx], idx-1, dp);
            return dp[idx,target] = notTaken + taken;
        }
    }
}