namespace DSA_C.Trees
{
    public class BTTopBottomView
    {
        public void Start()
        {
            TreeNode root = new TreeNode (1, new TreeNode(2, null, new TreeNode(5, new TreeNode(6, null, null), null)), new TreeNode(3, null, new TreeNode(7, new TreeNode(4, null, null), null)));
            var ans = BottomView(root);
            Console.WriteLine(string.Join(" ", ans));
            ans = TopView(root);
            Console.WriteLine(string.Join(" ", ans));
        }

        public IList<int> BottomView(TreeNode root) {
            var ans = new List<int>();
            if (root == null) return ans;

            SortedDictionary<int, int> map = new SortedDictionary<int, int>();
            Queue<(TreeNode, int)> queue = new Queue<(TreeNode, int)>();
            queue.Enqueue((root, 0));

            while (queue.Count > 0)
            {
                var item = queue.Dequeue();
                TreeNode node = item.Item1;
                int level = item.Item2;
                if (map.ContainsKey(level)) map[level] = node.val;
                else map.Add(level, node.val);
                if (node.left != null)
                    queue.Enqueue((node.left, level-1));
                if (node.right != null)
                    queue.Enqueue((node.right, level+1));
            }
            foreach(var entry in map.Keys)
                ans.Add(map[entry]);
            
            return ans;
        }

        public IList<int> TopView(TreeNode root) {
            var ans = new List<int>();
            if (root == null) return ans;

            SortedDictionary<int, int> map = new SortedDictionary<int, int>();
            Queue<(TreeNode, int)> queue = new Queue<(TreeNode, int)>();
            queue.Enqueue((root, 0));

            while (queue.Count > 0)
            {
                var item = queue.Dequeue();
                TreeNode node = item.Item1;
                int level = item.Item2;
                if (! map.ContainsKey(level))
                    map.Add(level, node.val);
                if (node.left != null)
                    queue.Enqueue((node.left, level-1));
                if (node.right != null)
                    queue.Enqueue((node.right, level+1));
            }
            foreach(var entry in map.Keys)
                ans.Add(map[entry]);
            
            return ans;
        }  
      
    }
}