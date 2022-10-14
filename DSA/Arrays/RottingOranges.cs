namespace DSA_C.Arrays
{
    public class RottingOranges
    {
        // https://leetcode.com/problems/rotting-oranges/
        public void Start()
        {
            int[][] mat = new int[][] {
                new int[] {2,1,1}, 
                new int[] {0,1,1},
                new int[] {1,0,1}
            };
            Console.WriteLine(OrangesRotting(mat));
        }

        int OrangesRotting(int[][] grid) {
            int n = grid.Length;
            int m = grid[0].Length;
            Queue<(int, int, int)> queue = new Queue<(int, int, int)>();
            int[,] visited = new int[n,m];
            int countFresh = 0;
            for (int i=0; i<n; i++) {
                for (int j=0; j<m; j++) {
                    if (grid[i][j] == 2) {
                        queue.Enqueue((i,j,0));
                        visited[i,j] = 2;
                    } else {
                        visited[i,j] = 0;
                    }
                    if (grid[i][j] == 1)
                        countFresh++;
                }
            }

            int time=0;
            int[] directions = new int[] {0,1,0,-1,0};
            int count=0;
            while (queue.Count > 0) {
                (int r, int c, int t) = queue.Dequeue();
                time = Math.Max(time, t);
                for (int i=0; i<4; i++) {
                    int new_r = r + directions[i];
                    int new_c = c + directions[i+1];
                    if (new_r>=0 && new_c>=0 && new_r<n && new_c<m 
                        && visited[new_r,new_c] == 0 && grid[new_r][new_c] == 1) {
                            queue.Enqueue((new_r, new_c, t+1));
                            visited[new_r,new_c] = 2;
                            count++;
                        }
                }
            }

            if (count != countFresh) return -1;
            return time;
        }
    }
}