namespace DSA_C.DP
{
    public class HouseRobberProblem
    {
        public void Start()
        {
            int[] nums = {2,7,9,3,1};
            Console.WriteLine(Rob(nums));
        }

        // https://leetcode.com/problems/house-robber/
        int Rob(int[] nums) {
            int n = nums.Length;
            if (n==1) return nums[0];
            nums[1]=Math.Max(nums[0], nums[1]);
            if (n==2) return nums[1];

            for(int i=2; i<n; i++)
            {
                nums[i]=Math.Max(nums[i-1], nums[i-2]+nums[i]);
            }
            return nums[n-1];
        }

        // https://leetcode.com/problems/house-robber-ii/
        int RobII(int[] nums) {
            int n = nums.Length;
            if (n==1) return nums[0];                        
            return Math.Max(MaxRob(nums, 0, n-1), MaxRob(nums, 1, n));
        }

        int MaxRob(int[] N, int left, int right)
        {
            var (rob1, rob2) = (0,0);
            for (int i=left; i<right; i++)
            {
                int tmp = Math.Max(N[i]+rob1, rob2);
                rob1 = rob2;
                rob2 = tmp;
            }
            return rob2;
        }
    }
}