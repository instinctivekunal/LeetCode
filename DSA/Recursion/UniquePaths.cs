namespace DSA_C.Recursion
{
    public class UniquePathsProblem
    {
        // https://leetcode.com/problems/unique-paths/
        public void Start()
        {
            int m=3;
            int n=7;
            Console.WriteLine(UniquePaths(m,n));
        }

        int UniquePaths1(int m, int n)
        {
            if(m == 1 || n == 1) return 1;
        
            long sum = m;
            for(int i = 2; i < n; i++){
                sum = sum*(m + 1)/i;
                m++;
            }
        
            return (int)sum;
        }

        int UniquePaths2(int m, int n)
        {
            int[,] dp = new int[m,n];
            for (int i=0; i<m; i++) {
                for (int j=0; j<n; j++) {
                    if (i==0 || j==0) {
                        dp[i,j] = 1;
                    } else {
                        dp[i,j] = dp[i-1,j] + dp[i,j-1];
                    }
                }
            }
            return dp[m-1,n-1];
        }

        int UniquePaths(int m, int n) {
            int[,] dp = new int[m+1,n+1];
            for(int i=0;i<=m;i++){
                for(int j=0;j<=n;j++){
                    dp[i,j] = -1;
                }
            }
            return UniquePathCount(m, n, 0, 0, dp);
        }

        int UniquePathCount(int m, int n, int row, int col, int[,] dp)
        {
            if (row >= m || col >= n)
                return 0;
            if (row == m-1 && col == n-1)
                return 1;

            if (dp[row,col] != -1)
                return dp[row,col];
            return dp[row,col] = UniquePathCount(m, n, row+1, col, dp) + UniquePathCount(m, n, row, col+1, dp);
        }
    }
}