namespace DSA_C.Trees
{
    #nullable disable
    public class BTVerticalOrderTraversal
    {
        // https://leetcode.com/problems/vertical-order-traversal-of-a-binary-tree/
        public class Tuple {
            public TreeNode node;
            public int row;
            public int col;
            public Tuple(TreeNode _node, int _row, int _col) {
                node = _node;
                row = _row;
                col = _col;
            }
        }

        public void Start()
        {
            TreeNode root = new TreeNode (1, new TreeNode(2, new TreeNode(4, null, null), new TreeNode(6, null, null)), new TreeNode(3, new TreeNode(5, null, null), new TreeNode(7, null, null)));
            var ans = VerticalTraversal(root);
            foreach(List<int> a in ans)
                Console.WriteLine(string.Join(" ", a));
        }

        public IList<IList<int>> VerticalTraversal(TreeNode root) {
            var ans = new List<IList<int>>();
            if (root == null) return ans;
            SortedDictionary<int, SortedDictionary<int, PriorityQueue<int, int>>> map = new SortedDictionary<int, SortedDictionary<int, PriorityQueue<int, int>>>();
            Queue<Tuple> queue = new Queue<Tuple>();
            queue.Enqueue(new Tuple(root, 0, 0));
            while(queue.Count > 0)
            {
                Tuple tuple = queue.Dequeue();
                var node = tuple.node;
                int r = tuple.row;
                int c = tuple.col;

                if (!map.ContainsKey(r))
                    map.Add(r, new SortedDictionary<int, PriorityQueue<int, int>>());
                if (!map[r].ContainsKey(c))
                    map[r].Add(c, new PriorityQueue<int, int>());
                map[r][c].Enqueue(node.val, node.val);

                if (node.left != null)
                    queue.Enqueue(new Tuple(node.left, r-1, c+1));
                if (node.right != null)
                    queue.Enqueue(new Tuple(node.right, r+1, c+1));
            }
            foreach(var item in map.Keys)
            {
                ans.Add(new List<int> ());
                foreach (var nodes in map[item].Values)
                {
                    while (nodes.Count > 0)
                        ans[ans.Count-1].Add(nodes.Dequeue());
                }
            }
            return ans;
        }
    }
}