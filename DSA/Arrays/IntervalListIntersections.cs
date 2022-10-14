namespace DSA_C.Arrays
{
    public class IntervalListIntersections
    {
        // https://leetcode.com/problems/interval-list-intersections/
        public void Start()
        {
            int[][] nums1 = new int[][] {
                new int[] {0,2},
                new int[] {5,10},
                new int[] {13,23},
                new int[] {24,25},
            };
            int[][] nums2 = new int[][] {
                new int[] {1,5},
                new int[] {8,12},
                new int[] {15,24},
                new int[] {25,26},
            };
            //Console.WriteLine(string.Join(",", Intersect(nums1, nums2)));
            var ans = IntervalIntersection(nums1, nums2);
        }

        /* Algorithm
If A[0] has the smallest endpoint, it can only intersect B[0]. After, we can discard A[0] since it cannot intersect anything else.
Similarly, if B[0] has the smallest endpoint, it can only intersect A[0], and we can discard B[0] after since it cannot intersect anything else.
We use two pointers, i and j, to virtually manage "discarding" A[0] or B[0] repeatedly.
        */
        int[][] IntervalIntersection(int[][] firstList, int[][] secondList) {
            var ans = new List<int[]>();
            int i=0, j=0;
            while (i < firstList.Length && j < secondList.Length)
            {
                // Let's check if A[i] intersects B[j].
                // lo - the startpoint of the intersection
                // hi - the endpoint of the intersection
                int lo = Math.Max(firstList[i][0], secondList[j][0]);
                int hi = Math.Min(firstList[i][1], secondList[j][1]);
                if (lo <= hi) ans.Add(new int[] {lo, hi});
                
                // Remove the interval with the smallest endpoint
                if (firstList[i][1] < secondList[j][1]) i++;
                else j++;
            }
            return ans.ToArray();
        }
    }
}