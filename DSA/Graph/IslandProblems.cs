namespace DSA_C.Graph
{
    public class IslandProblems
    {
        public void Start()
        {
            // https://leetcode.com/problems/number-of-islands/
            char[][] grid = new char[][] {
                new char[] {'1','1','1','1','0'},
                new char[] {'1','1','0','1','0'},
                new char[] {'1','1','0','0','0'},
                new char[] {'0','0','0','0','0'},
            };
            Console.WriteLine(NumIslands(grid));

            // https://leetcode.com/problems/max-area-of-island/
            int[][] g = new int[][] {
                new int[] {1,1,0,0,0},
                new int[] {1,1,0,0,0},
                new int[] {0,0,0,1,1},
                new int[] {0,0,0,1,1}
            };
            Console.WriteLine(MaxAreaOfIsland(g));

            // https://leetcode.com/problems/number-of-closed-islands/
            int[][] g1 = new int[][] {
                new int[] {1,1,1,1,1,1,1,0},
                new int[] {1,0,0,0,0,1,1,0},
                new int[] {1,0,1,0,1,1,1,0},
                new int[] {1,0,0,0,0,1,0,1},
                new int[] {1,1,1,1,1,1,1,0},
            };
            Console.WriteLine(ClosedIsland(g1));

            // https://leetcode.com/problems/number-of-enclaves/
            int[][] g2 = new int[][] {
                new int[] {0,1,1,0},
                new int[] {0,0,1,0},
                new int[] {0,1,1,0},
                new int[] {0,0,0,0}
            };
            Console.WriteLine(NumEnclaves(g2));

            // https://leetcode.com/problems/count-sub-islands/
            int[][] G1 = new int[][] {
                new int[] {1,1,1,0,0},
                new int[] {0,1,1,1,1},
                new int[] {0,0,0,0,0},
                new int[] {1,0,0,0,0},
                new int[] {1,1,0,1,1}
            };
            int[][] G2 = new int[][] {
                new int[] {1,1,1,0,0},
                new int[] {0,0,1,1,1},
                new int[] {0,1,0,0,0},
                new int[] {1,0,1,1,0},
                new int[] {0,1,0,1,0}
            };
            Console.WriteLine(CountSubIslands(G1, G2));
        }

        int NumIslands(char[][] grid) {
            int ans = 0;
            bool[][] seen = new bool[grid.Length][];
            for (int i=0; i<grid.Length; i++)
                seen[i] = new bool[grid[i].Length];

            for (int i=0; i<grid.Length; i++)
                for (int j=0; j<grid[i].Length; j++)
                {
                    if (seen[i][j]) continue;
                    if (grid[i][j] == '1') {
                        ans++;
                        VisitAdjacent(grid, i, j, seen);
                    }
                }
            return ans;
        }

        void VisitAdjacent(char[][] grid, int row, int col, bool[][] seen)
        {
            if (row<0 || row>=grid.Length || col<0 || col >= grid[row].Length) return;
            if (seen[row][col] || grid[row][col] == '0') return;

            seen[row][col] = true;
            VisitAdjacent(grid, row-1, col, seen);
            VisitAdjacent(grid, row+1, col, seen);
            VisitAdjacent(grid, row, col+1, seen);
            VisitAdjacent(grid, row, col-1, seen);
        }

        int MaxAreaOfIsland(int[][] grid) {
            int ans = 0;
            bool[][] seen = new bool[grid.Length][];
            for (int i=0; i<grid.Length; i++)
                seen[i] = new bool[grid[i].Length];

            for (int i=0; i<grid.Length; i++)
                for (int j=0; j<grid[i].Length; j++)
                {
                    if (seen[i][j]) continue;
                    if (grid[i][j] == 1) {
                        int count = VisitAdjacentArea(grid, i, j, seen);
                        ans = Math.Max(ans, count);
                    }
                }
            return ans;        
        }

        int VisitAdjacentArea(int[][] grid, int row, int col, bool[][] seen)
        {
            int count=0;
            if (row<0 || row>=grid.Length || col<0 || col >= grid[row].Length) return 0;
            if (seen[row][col] || grid[row][col] == 0) return 0;

            seen[row][col] = true;
            count++;
            count += VisitAdjacentArea(grid, row-1, col, seen);
            count += VisitAdjacentArea(grid, row+1, col, seen);
            count += VisitAdjacentArea(grid, row, col+1, seen);
            count += VisitAdjacentArea(grid, row, col-1, seen);
            return count;
        }

        int ClosedIsland(int[][] grid) {
            int ans = 0;
            for (int i=0; i<grid.Length; i++)
                for (int j=0; j<grid[i].Length; j++) {
                    if (grid[i][j] == 0 && Dfs(grid, i, j))
                        ans++;
                }
            return ans;
        }

        bool Dfs(int[][] grid, int row, int col) {
            if (row<0 || row>=grid.Length || col<0 || col>=grid[row].Length)
                return false;
            if (grid[row][col] == 1)
                return true;
            grid[row][col] = 1;
            bool up = Dfs(grid, row-1, col);
            bool down = Dfs(grid, row+1, col);
            bool left = Dfs(grid, row, col-1);
            bool right = Dfs(grid, row, col+1);
            return up && down && left && right;
        }

        int NumEnclaves(int[][] grid) {
            // Boundary Traversal
            for (int i=0; i<grid.Length; i++)
                for (int j=0; j<grid[i].Length; j++) {
                    if (i*j == 0 || i == grid.Length-1 || j == grid[i].Length -1)
                        if (grid[i][j] == 1)
                            DfsTraverse(grid, i, j);
                }
            
            int ans = 0;           
            for (int i=0; i<grid.Length; i++)
                for (int j=0; j<grid[i].Length; j++) {
                    if (grid[i][j] == 1) ans++;
                }            
            return ans;
        }

        void DfsTraverse(int[][] grid, int row, int col) {            
            if (row<0 || row>=grid.Length || col<0 || col>=grid[row].Length)
                return;
            if (grid[row][col] == 0)
                return;
            grid[row][col] = 0;
            DfsTraverse(grid, row-1, col);
            DfsTraverse(grid, row+1, col);
            DfsTraverse(grid, row, col-1);
            DfsTraverse(grid, row, col+1);
        }

        int CountSubIslands(int[][] G1, int[][] G2) {
            int ans = 0;
            for (int i=0; i<G1.Length; i++)
                for (int j=0; j<G1[i].Length; j++) {
                    if (G2[i][j] == 1) {
                        int isSub = 1;
                        DfsSubIsland(G1, G2, i, j, ref isSub);
                        ans += isSub;
                    }                    
                }
            return ans;        
        }

        void DfsSubIsland(int[][] G1, int[][] G2, int row, int col,ref int isSub)
        {
            if (row<0 || row>=G1.Length || col<0 || col>=G1[row].Length || G2[row][col] == 0)
                return;
            if (G1[row][col] == 0)
                isSub = 0;
            G2[row][col] = 0;
            DfsSubIsland(G1, G2, row-1, col, ref isSub);
            DfsSubIsland(G1, G2, row+1, col, ref isSub);
            DfsSubIsland(G1, G2, row, col-1, ref isSub);
            DfsSubIsland(G1, G2, row, col+1, ref isSub);
        }
    }
}