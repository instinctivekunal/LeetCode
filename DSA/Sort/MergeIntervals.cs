namespace DSA_C.Sort
{
    public class MergeIntervals
    {
        public void Start()
        {
             int[][] mat = new int[][] {
                new int[] {2,6},
                new int[] {1,3}, 
                new int[] {8,10},
                new int[] {15,18}
            };
            var res = Merge(mat);
            foreach( var item in res)
                Console.WriteLine(string.Join(",", item));
        }

         int[][] Merge(int[][] intervals) 
        {
            if (intervals.Length <= 1) return intervals;
            //Sorts the rows based on the first column i.e. 0th column
            Array.Sort(intervals, (a,b) => a[0].CompareTo(b[0]));
            List<int[]> ans = new List<int[]> {intervals[0]};
            int idx=0;

            for (int i=1; i<intervals.Length; i++)
            {
                if(intervals[i][0] > ans[idx][1])
                {
                    ans.Add(intervals[i]);
                    idx++;
                }
                else if(intervals[i][0] <= ans[idx][1])
                    ans[idx][1] = Math.Max(intervals[i][1], ans[idx][1]);
            }

            return ans.ToArray();
            
            // var ans = new int[intervals.Length][];
            // Sort(intervals);
            // int k=0;
            // ans.Append(intervals[0]);
            // for (int i=1; i<intervals.Length; i++)
            // {
            //     if (intervals[i-1][1] > intervals[i][0])
            //         ans[k++] = new int[2] {intervals[i-1][0], intervals[i][1]};
            //     else if (intervals[])
            //         ans[k++] = new int[2] {intervals[i-1][0], intervals[i-1][1]};
            // }
        
            // return ans;
        }

         void Sort(int[][] arr)
        {
            for(int i=1; i<arr.Length; i++)
            {
                if(arr[i][0] < arr[i-1][0])
                {
                    int[] temp = arr[i];
                    arr[i] = arr[i-1];
                    arr[i-1] = temp;
                }
            }
        }
    }
}