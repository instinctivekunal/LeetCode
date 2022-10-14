namespace DSA_C.Graph
{
    public class TopoSortBFS
    {
        public void Start()
        {
            int V=5;
            int[][] edges = new int[][] {
                new int[] {1, 4},
                new int[] {2, 4},
                new int[] {3, 1},
                new int[] {3, 2}
            };
            Console.WriteLine(isCycle(V, edges));
        }

        public bool isCycle(int V, int[][] edges)
        {
            var adj = CreateAdjacencyList(V, edges, false);
            return IsCyclic(V, adj);
        }

        public IList<IList<int>> CreateAdjacencyList(int V, int[][] edges, bool isDirected)
        {
            IList<IList<int>> adj = new List<IList<int>>(edges.Length);
            for (int i=0; i<=V; i++)
                adj.Add(new List<int>());

            foreach(int[] pair in edges)
            {
                adj[pair[0]].Add(pair[1]);
                if (isDirected) adj[pair[1]].Add(pair[0]);
            }
            return adj;
        }

        public bool IsCyclic(int N, IList<IList<int>> adj)
        {
            int[] indegree = new int[N];
            // Calculate In degree
            for (int i=0; i<N; i++)
            {
                foreach(int v in adj[i])
                    indegree[v]++;
            }

            // Add indegree = 0 in queue
            Queue<int> q = new Queue<int>();
            for (int i=0; i<N; i++)
            {
                if (indegree[i] == 0)
                    q.Enqueue(i);
            }

            int count = 0;
            while(q.Count>0)
            {
                int node = q.Dequeue();
                count++;
                foreach(int v in adj[node]) {
                    indegree[v]--;
                    if (indegree[v] == 0)
                        q.Enqueue(v);
                }
            }
            return !(count == N);
        }
    }
}