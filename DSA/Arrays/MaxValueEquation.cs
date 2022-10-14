namespace DSA_C.Arrays
{
    #nullable disable
    public class MaxValueEquation
    {
        public void Start()
        {
            int[][] points = new int[][] {
                new int[] {0,0}, 
                new int[] {3,0},
                new int[] {9,2}
            };
            Console.WriteLine(FindMaxValueOfEquation(points, 3));
        }

         int FindMaxValueOfEquation(int[][] points, int k) 
        {
            int max = int.MinValue;
            var q = new LinkedList<int[]>();
            for (int i=0; i<points.Length; i++)
            {
                int x = points[i][0];
                int y = points[i][1];
                int diff = y-x;
                Console.WriteLine("S->{0}..{1}..{2}..{3}..{4}",x, y, diff, max, q.Count);
                while (q.Count>0 && q.First.Value[1] < x-k)
                    q.RemoveFirst();
                if (q.Count>0)
                    max = Math.Max(max, q.First.Value[0] + x + y);
                while(q.Count>0 && q.Last.Value[0] <= diff)
                    q.RemoveLast();
                q.AddLast(new int[] {diff,x});
                Console.WriteLine("E->{0}..{1}..{2}..{3}..{4}",x, y, diff, max, q.Count);
                foreach(int[] item in q)
                    Console.WriteLine(string.Join("\t", item));
            }
            return max;
        }
    }
}