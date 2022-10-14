namespace DSA_C.Arrays
{
    public class MatrixKWeakestRows
    {
        // https://leetcode.com/problems/the-k-weakest-rows-in-a-matrix/
        public void Start()
        {
            int[][] mat = new int[][] {
                new int[] {1,1,0,0,0}, 
                new int[] {1,1,1,1,0},
                new int[] {1,0,0,0,0},
                new int[] {1,1,0,0,0},
                new int[] {1,1,1,1,1}
            };
            Console.WriteLine(KWeakestRows(mat, 3));
        }

        int[] KWeakestRows(int[][] mat, int k) {
            PriorityQueue<int,(int, int)> pq = new PriorityQueue<int, (int, int)>();
            for (int i=0; i<mat.Length; i++) {
                int soldiers = 0;
                for (int j=0; j<mat[i].Length; j++) {
                    if (mat[i][j] == 1) soldiers++;
                }
                pq.Enqueue(i, (soldiers, i));
            }
            int[] ans = new int[k];
            for (int i=0; i<k; i++)
                ans[i] = pq.Dequeue();
            return ans;
        }
    }
}