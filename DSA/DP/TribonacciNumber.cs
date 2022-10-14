namespace DSA_C.DP
{
    public class TribonacciNumber
    {
        // https://leetcode.com/problems/n-th-tribonacci-number/
        public void Start()
        {
            int n = 25;
            Console.WriteLine(Tribonacci(n));
        }

        int Tribonacci(int n) {
            if (n<2) return n;
            int t0=0, t1=1, t2=1, op=0;
            while (n-- > 2)
            {
                op = t0 + t1 + t2;
                t0 = t1;
                t1 = t2;
                t2 = op;
            }
            return t2;
        }

        int Tribonacci1(int n) {
            int[] dp = new int[n+1];
            dp[0] = 0;
            if (n == 0) return dp[n];
            if (n <= 2) return 1;
            if (dp[n] != 0) return dp[n];
            dp[n] = Tribonacci(n-1) + Tribonacci(n-2) + Tribonacci(n-3);
            return dp[n];
        }
    }
}