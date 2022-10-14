namespace DSA_C.Arrays
{
    public class SpiralMatrix
    {
        public void Start()
        {
            int[][] mat = new int[][] {
                new int[] {1,4,7,11,15}, 
                new int[] {2,5,8,12,19},
                new int[] {3,6,9,16,22},
                new int[] {10,13,14,17,24},
                new int[] {18,21,23,26,30}
            };
            Console.WriteLine(string.Join("\t", SpiralOrder(mat)));
        }

         IList<int> SpiralOrder(int[][] matrix) 
        {
            IList<int> ans = new List<int>();
            int top = 0;
            int bottom = matrix.Length-1;
            int left = 0;
            int right = matrix[0].Length-1;
            int dir = 0;
            
            while (top<=bottom && left<=right)
            {
                switch(dir)
                {
                    case 0: // Right
                        for (int i=left; i<=right; i++)
                            ans.Add(matrix[top][i]);
                        top++;
                        break;
                    case 1: // Down
                        for (int i=top; i<=bottom; i++)
                            ans.Add(matrix[i][right]);
                        right--;
                        break;
                    case 2: // Left
                        for (int i=right; i>=left; i--)
                            ans.Add(matrix[bottom][i]);
                        bottom--;
                        break;
                    case 3: // Up
                        for (int i=bottom; i>=top; i--)
                            ans.Add(matrix[i][left]);
                        left++;
                        break;
                }
                dir = (dir+1)%4;
            }
            return ans.ToList();         
        }
    }
}