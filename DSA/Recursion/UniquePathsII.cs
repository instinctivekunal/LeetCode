namespace DSA_C.Recursion
{
    public class UniquePathsII
    {
        // https://leetcode.com/problems/unique-paths-ii/
        public void Start()
        {
            int[][] board = new int[3][] {
                new int[] {0,0,0},
                new int[] {0,0,0},
                new int[] {0,0,0}
            };

            Console.WriteLine(UniquePathsWithObstacles(board));
        }

        int UniquePathsWithObstacles(int[][] obstacleGrid) {
            int m = obstacleGrid.Length - 1;
            int n = obstacleGrid[0].Length -1;
            if (obstacleGrid[m][n] == 1)
                return 0;
            int[,] dp = new int[m+1,n+1];
            for(int i=0;i<=m;i++){
                for(int j=0;j<=n;j++){
                    if(obstacleGrid[i][j] != 1){
                        dp[i,j] = -1;
                    }
                }
            }
            return UniquePathCount(obstacleGrid, 0, 0, dp);
        }

        int UniquePathCount(int[][] obstacleGrid, int row, int col, int[,] dp)
        {
            int rows = obstacleGrid.Length - 1;
            int cols = obstacleGrid[0].Length -1;
            if (row >= rows+1 || col >= cols+1 || obstacleGrid[row][col] == 1)
                return 0;
            if (row == rows && col == cols)
                return obstacleGrid[row][col] == 1 ? 0 : 1;

            if (dp[row,col] != -1)
                return dp[row,col];
            return dp[row,col] = UniquePathCount(obstacleGrid, row+1, col, dp) + UniquePathCount(obstacleGrid, row, col+1, dp);
        }
    }
}