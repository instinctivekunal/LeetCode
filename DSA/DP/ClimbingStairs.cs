namespace DSA_C.DP
{
    public class ClimbingStairs
    {
        public void Start()
        {
            int n = 3;
            Console.WriteLine(ClimbStairs(n));
            int[] cost = {1,100,1,1,1,100,1,1,100,1};
            Console.WriteLine(MinCostClimbingStairs(cost));
        }

        // https://leetcode.com/problems/climbing-stairs/
        int ClimbStairs(int n) {
            int[] ans = new int[n+1];
            for (int i=0; i<=n; i++)
            {
                if (i <= 2)
                    ans[i] = i;
                else
                    ans[i] = ans[i-1]+ans[i-2];
            }
            return ans[n];
        }

        // https://leetcode.com/problems/min-cost-climbing-stairs/
        int MinCostClimbingStairs(int[] cost) {
            for (int i=2; i<cost.Length; i++)
                cost[i] = Math.Min(cost[i-1], cost[i-2]) + cost[i];
            return Math.Min(cost[cost.Length-1], cost[cost.Length-2]);
        }
    }    
}