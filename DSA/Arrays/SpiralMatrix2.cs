namespace DSA_C.Arrays
{
    public class SpiralMatrix2
    {
        public void Start()
        {
            var mat = GenerateMatrix(5);
            foreach(int[] row in mat)
                Console.WriteLine(string.Join("\t", row));
        }

         int[][] GenerateMatrix(int n) 
        {
            var ans = new int[n][];
            int top = 0;
            int bottom = n-1;
            int left = 0;
            int right = n-1;
            int dir = 0;
            int digit = 1;

            for (var q=0; q<n; q++) 
                ans[q] = new int[n];
            
            while (top<=bottom && left<=right)
            {
                switch(dir)
                {
                    case 0: // Right
                        for (int i=left; i<=right; i++)
                            ans[top][i] = digit++;
                        top++;
                        break;
                    case 1: // Down
                        for (int i=top; i<=bottom; i++)
                            ans[i][right] = digit++;
                        right--;
                        break;
                    case 2: // Left
                        for (int i=right; i>=left; i--)
                            ans[bottom][i] = digit++;
                        bottom--;
                        break;
                    case 3: // Up
                        for (int i=bottom; i>=top; i--)
                            ans[i][left] = digit++;
                        left++;
                        break;
                }
                dir = (dir+1)%4;
            }
            return ans;         
        }
    }
}