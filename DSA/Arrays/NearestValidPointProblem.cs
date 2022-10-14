namespace DSA_C.Arrays
{
    public class NearestValidPointProblem
    {
        public void Start()
        {
            int x=3, y=4;
            int[][] points = new int[][] {
                // new int[] {1,2},
                // new int[] {3,1},
                // new int[] {2,4},
                // new int[] {2,3},
                // new int[] {4,4},
                new int[] {2,3}
            };
            Console.WriteLine(NearestValidPoint(x,y,points));
        }

        int NearestValidPoint(int x, int y, int[][] points) {
            int dist = int.MaxValue, idx = -1;
            for (int i=0; i<points.Length; i++)
            {
                var pt = points[i];
                if (pt[0] == x || pt[1] == y)
                {
                    int d = Math.Abs(pt[0]-x) + Math.Abs(pt[1]-y);
                    if (d < dist)
                    {
                        dist = d;
                        idx = i;
                    }
                }
            }
            return idx;
        }
    }
}