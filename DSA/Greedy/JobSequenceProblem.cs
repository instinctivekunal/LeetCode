namespace DSA_C.Greedy
{
    public class JobSequenceProblem
    {
        // https://practice.geeksforgeeks.org/problems/job-sequencing-problem-1587115620/1#
        public class Job{
            public int id;
            public int dead;
            public int profit;
            public Job(int id,int dead,int profit) {
                this.id = id;
                this.dead = dead;
                this.profit = profit;
            }
        }
        public void Start()
        {
            Job[] arr = new Job[4];
            arr[0] = new Job(1, 4, 20);
            arr[1] = new Job(2, 1, 10);
            arr[2] = new Job(3, 2, 40);
            arr[3] = new Job(4, 2, 30);

            Console.WriteLine(string.Join(" ", JobScheduling(arr, 4)));
        }

        public int[] JobScheduling(Job[] arr, int n)
        {
            // Sort array in descending order of profits
            Array.Sort(arr, (a,b) => b.profit-a.profit);
            // Get the maximum deadline
            int max = 0;
            foreach(Job j in arr)
                if (j.dead > max) 
                    max = j.dead;
            // Initialize array with -1
            int[] ans = new int[max+1];
            for (int i=0; i<=max; i++)
                ans[i] = -1;

            // Get the max profit
            int jobs = 0, profit = 0;
            for (int i=0; i<n; i++) {
                for (int j=arr[i].dead; j>0; j--) {
                    if (ans[j] == -1) {
                        ans[j] = i;
                        jobs++;
                        profit += arr[i].profit;
                        break;
                    }
                }
            }
            return new int[2] {jobs, profit};
        }
    }
}