namespace DSA_C.Arrays
{
    public class MatrixDiagonalSum
    {
        public void Start()
        {
            int[][] mat = new int[][] {
                new int[] {1,2,3}, 
                new int[] {4,5,6},
                new int[] {7,8,9}
            };
            Console.WriteLine(DiagonalSum(mat));
        }

        int DiagonalSum(int[][] mat) {
            int sum = 0;
            int n = mat.Length;
            for (int i=0; i<n; i++) {
                for (int j=0; j<n; j++) {
                    if (i == j) 
                        sum += mat[i][j];
                    else
                        if ((i+j) == n-1) sum += mat[i][j];
                }
            }
            return sum;
        }
    }
}