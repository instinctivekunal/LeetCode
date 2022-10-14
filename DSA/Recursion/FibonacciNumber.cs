namespace DSA_C.Recursion
{
    public class FibonacciNumber
    {
        // https://leetcode.com/problems/fibonacci-number/
        public void Start()
        {
            int n = 5;
            Console.WriteLine(Fib(n));
        }

        int Fib(int n)
        {
            int[] dp = new int[n+1];
            dp[0] = 0;
            if (n <= 1)
                return n;
            if (dp[n] != 0)
                return dp[n];
            
            dp[n] = Fib(n-1) + Fib(n-2);
            return dp[n];
        }
    }
}