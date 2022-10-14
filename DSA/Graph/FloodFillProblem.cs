namespace DSA_C.Graph
{
    public class FloodFillProblem
    {
        public void Start()
        {
            int[][] image = new int[][] {
                new int[] {0,0,0},
                new int[] {0,0,0}
            };
            var ans = FloodFill(image,1,1,2);
            foreach(int[] n in ans)
                Console.WriteLine(string.Join(" ", n));
        }

        int[][] FloodFill(int[][] image, int sr, int sc, int color) {
            int oriColor = image[sr][sc];
            if (color == oriColor) return image;

            image[sr][sc] = color;
            if (sr+1 < image.Length && image[sr+1][sc] == oriColor)
                FloodFill(image, sr+1, sc, color);
            if (sr-1 >= 0 && image[sr-1][sc] == oriColor)
                FloodFill(image, sr-1, sc, color);
            
            if (sc-1 >= 0 && image[sr][sc-1] == oriColor)
                FloodFill(image, sr, sc-1, color);
            if (sc+1 < image[0].Length && image[sr][sc+1] == oriColor)
                FloodFill(image, sr, sc+1, color);
            return image;
        }
    }
}