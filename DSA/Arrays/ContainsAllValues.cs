namespace DSA_C.Arrays
{
    public class ContainsAllValues
    {
        public void Start()
        {
            int[][] mat = new int[][] {
                new int[] {1,2,3}, 
                new int[] {2,3,1},
                new int[] {1,1,2}
            };
            Console.WriteLine(CheckValid(mat));
        }

        bool CheckValid(int[][] matrix) 
        {
            int n = matrix.Length;
            for (int i=0; i<n; i++)
            {
                HashSet<int> r = new HashSet<int>();
                HashSet<int> c = new HashSet<int>();
                for(int j=0; j<n; j++)
                {
                    if (!r.Add(matrix[i][j]) || !c.Add(matrix[j][i]))
                        return false;
                }
            }
            return true;
        }
    }
}