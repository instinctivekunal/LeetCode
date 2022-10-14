namespace DSA_C.Arrays
{
    public class ReshapeMatrix
    {
        public void Start()
        {
            int[][] mat = new int[][] {
                new int[] {1,2}, new int[] {3,4}
            };
            int r = 1;
            int c = 4;
            int[][] res = MatrixReshape(mat, r, c);
            for(int i=0; i<res.Length; i++)
            {
                Console.WriteLine(string.Join(",", res[i]));
            }
        }

        int[][] MatrixReshape(int[][] mat, int r, int c)
        {
            int m = mat.Length;
            int n = mat[0].Length;
            if (m*n != r*c)
                return mat;
            var res = new int[r][];
            for (var q=0; q<r; q++) 
                res[q] = new int[c];
            for(int i=0; i<r*c; i++)
            {
                res[i/c][i%c] = mat[i/n][i%n];
            }
            return res;
        }

        int[][] Construct2DArray(int[] original, int r, int c)
        {            
            if (original.Length != r*c)
                return new int[0][];
            var res = new int[r][];
            for (var q=0; q<r; q++) 
                res[q] = new int[c];
            for(int i=0; i<r*c; i++)
                res[i/c][i%c] = original[i];
            return res;
        }        
    }    
}