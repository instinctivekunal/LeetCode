namespace DSA_C.Arrays
{
    public class MatrixSearch
    {
        // https://leetcode.com/problems/search-a-2d-matrix/
        public void Start()
        {
            int[][] mat = new int[][] {
                new int[] {1,2,3}, 
                new int[] {4,5,6},
                new int[] {7,8,9}
            };
            Console.WriteLine(SearchMatrix(mat, 1));
        }

        bool SearchMatrix(int[][] matrix, int target) 
        {
            int m = matrix.Length;
            int n = matrix[0].Length;
            int l = 0;
            int h = (m*n)-1;
            while (l<=h)
            {
                int mid = (l+h)/2;
                int row = mid/n;
                int col = mid%n;
                if (matrix[row][col] == target)
                    return true;
                if (matrix[row][col] > target)
                    h = mid-1;
                else
                    l = mid+1;
            }
            return false;
        }
    }
}