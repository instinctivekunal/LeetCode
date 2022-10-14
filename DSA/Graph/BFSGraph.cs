namespace DSA_C.Graph
{
    public class BFSGraph
    {
        public void Start()
        {
            IList<IList<int>> adj = new List<IList<int>> {
                new List<int> {1},
                new List<int> {2,3,4,5},
                new List<int> {4,1},
                new List<int> {1},
                new List<int> {1,2},
                new List<int> {1}
            };
            var ans = BfsOfGraph(5, adj);

            int V=5;
            int[][] edges = new int[][] {
                new int[] {1, 4},
                new int[] {2, 4},
                new int[] {3, 1},
                new int[] {3, 2}
            };
            Console.WriteLine(isCycle(V, edges));
        }

        public IList<int> BfsOfGraph(int V, IList<IList<int>> adj)
        {
            IList<int> ans = new List<int>();
            bool[] visited = new bool[V+1];
            Queue<int> queue = new Queue<int>();
            queue.Enqueue(0);
            visited[0] = true;
            while (queue.Count > 0)
            {
                int node = queue.Dequeue();
                ans.Add(node);
                foreach(var list in adj[node]) {
                    if (!visited[list]) {
                        visited[list] = true;
                        queue.Enqueue(list);
                    }
                }
            }            
            return ans;
        }

        public IList<IList<int>> CreateAdjacencyList(int V, int[][] edges)
        {
            IList<IList<int>> adj = new List<IList<int>>(edges.Length);
            for (int i=0; i<=V; i++)
                adj.Add(new List<int>());

            foreach(int[] pair in edges)
            {
                adj[pair[0]].Add(pair[1]);
                adj[pair[1]].Add(pair[0]);
            }
            return adj;
        }

        public bool isCycle(int V, int[][] edges)
        {
            bool[] visited = new bool[V];
            Array.Fill(visited, false);
            var adj = CreateAdjacencyList(V, edges);

            for (int i=0; i<V; i++)
                if  (!visited[i])
                    if (CheckCycle(i, adj, visited))
                        return true;
            return false;
        }

        public bool CheckCycle(int ip, IList<IList<int>> adj, bool[] visited)
        {
            Queue<(int, int)> queue = new Queue<(int, int)>();
            queue.Enqueue((ip, -1));
            visited[ip] = true;
            while (queue.Count>0)
            {
                var (curr, parent) = queue.Dequeue();
                foreach(int edge in adj[curr])
                {
                    if (!visited[edge])
                    {
                        queue.Enqueue((edge, curr));
                        visited[edge] = true;
                    }
                    else if (edge != parent)
                        return true;
                }
            }
            return false;
        }
    }
}