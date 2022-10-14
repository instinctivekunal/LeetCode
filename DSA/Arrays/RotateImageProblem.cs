namespace DSA_C.Arrays
{
    public class RotateMatrixProblem
    {
        // https://leetcode.com/problems/rotate-image/
        public void Start()  
        {
            int[][] mat = new int[][] {
                new int[] {1,2,3}, 
                new int[] {4,5,6},
                new int[] {7,8,9}
            };
            Rotate(mat);
        }

        void Rotate(int[][] matrix) {
            int n = matrix.Length;
            // Transpose Matrix
            for (int i=0; i<n; i++)
            {
                for (int j=i; j<n; j++)
                {
                    int temp = matrix[i][j];
                    matrix[i][j] = matrix[j][i];
                    matrix[j][i] = temp;
                }
            }
            // Reverse the rows
            for (int i=0; i<n; i++)
            {
                for (int j=0; j<n/2; j++)
                {
                    int temp = matrix[i][j];
                    matrix[i][j] = matrix[i][n-1-j];
                    matrix[i][n-1-j] = temp;
                }
            }
        }

        void Rotate1(int[][] matrix) {
            int n = matrix.Length;
            int[][] rotate = new int[n][];
            for (var q=0; q<n; q++) 
                rotate[q] = new int[n];
            for (int i=0; i<n; i++)
            {
                for (int j=0; j<n; j++)
                {
                    rotate[j][n-i-1]=matrix[i][j];
                }
            }
            matrix = rotate;
        }

        bool FindRotation(int[][] matrix, int[][] target) {
            for (int i=0; i<4; i++)
            {
                if (Check(matrix, target))
                    return true;
                Rotate(matrix);
            }
            return false;
        }

        bool Check(int[][] A, int[][] B)
        {
            for (int i = 0; i < A.Length; i++)
            {
                for (int j = 0; j < B.Length; j++){
                    if(A[i][j] != B[i][j]){
                        return false;
                    }
                }
            }
            return true;
        }
    }
}
