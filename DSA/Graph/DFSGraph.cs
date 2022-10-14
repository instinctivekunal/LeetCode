namespace DSA_C.Graph
{
    public class DFSGraph
    {
        public void Start()
        {
            IList<IList<int>> adj = new List<IList<int>> {
                new List<int> {},
                new List<int> {2,3,4,5},
                new List<int> {4,1},
                new List<int> {1},
                new List<int> {1,2},
                new List<int> {1}
            };
            var ans = DfsOfGraph(5, adj);
        }

        public IList<int> DfsOfGraph(int V, IList<IList<int>> adj)
        {
            IList<int> ans = new List<int>();
            bool[] visited = new bool[V+1];
            for (int i=1; i<=V; i++)
                if (!visited[i])
                    DFS(i, visited, adj, ans);
            return ans;
        }

        public void DFS(int V, bool[] visited, IList<IList<int>> edges, IList<int> ans)
        {
            ans.Add(V);
            visited[V] = true;
            foreach (int v in edges[V])
                if (!visited[v])
                    DFS(v, visited, edges, ans);
        }
    }
}