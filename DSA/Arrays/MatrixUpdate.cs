namespace DSA_C.Arrays
{
    public class MatrixUpdate
    {
        // https://leetcode.com/problems/01-matrix/description
        public void Start()
        {
            int[][] mat = new int[][] {
                new int[] {0,0,0}, 
                new int[] {0,1,0},
                new int[] {1,1,1}
            };
            var ans = UpdateMatrix(mat);
            for(int i=0; i<ans.Length; i++)
            {
                Console.WriteLine(string.Join(",", ans[i]));
            }
        }

        int[] DIRECTIONS = new int[] {0,1,0,-1,0};
        int[][] UpdateMatrix(int[][] mat) {
            int m = mat.Length;
            int n = mat[0].Length;
            Queue<int[]> queue = new Queue<int[]>();
            for (int r=0; r<m; r++) {
                for (int c=0; c<n; c++) {
                    if (mat[r][c] == 0)
                        queue.Enqueue(new int[] {r,c});
                    else
                        mat[r][c] = -1;
                }
            }

            while (queue.Count > 0)
            {
                int[] item = queue.Dequeue();
                int r = item[0];
                int c = item[1];
                for (int i=0; i<4; i++) {
                    int new_r = r+DIRECTIONS[i];
                    int new_c = c+DIRECTIONS[i+1];
                    if (new_r<0 || new_c<0 || new_r==m || new_c==n || mat[new_r][new_c] != -1)
                        continue;
                    mat[new_r][new_c] = mat[r][c] + 1;
                    queue.Enqueue(new int[] {new_r, new_c});
                }
            }

            return mat;
        }
    }
}