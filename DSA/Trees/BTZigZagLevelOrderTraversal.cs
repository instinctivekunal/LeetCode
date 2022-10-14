namespace DSA_C.Trees
{
    public class BTZigZagLevelOrderTraversal
    {
        // https://leetcode.com/problems/binary-tree-level-order-traversal/
        public void Start()
        {
            TreeNode root = new TreeNode (1, new TreeNode(2, new TreeNode(4, new TreeNode(8, null, null), null), new TreeNode(6, null, null)), new TreeNode(3, new TreeNode(5, null, null), new TreeNode(7, new TreeNode(9, null, null), null)));
            var ans = ZigzagLevelOrder(root);
            Console.WriteLine(FindBottomLeftValue(root));
            Console.WriteLine(MaxPathSum(new TreeNode(-3, null, null)));
        }

        // https://leetcode.com/problems/binary-tree-zigzag-level-order-traversal/
        public IList<IList<int>> ZigzagLevelOrder(TreeNode root) 
        {
            var ans = new List<IList<int>>();
            if (root == null) return ans;

            Queue<TreeNode> queue = new Queue<TreeNode>();
            queue.Enqueue(root);
            bool flag = true;
            while (queue.Count > 0)
            {
                int size = queue.Count;
                var list = new List<int>(size);
                while (size-- > 0)
                {
                    var node = queue.Dequeue();
                    if (node.left != null) queue.Enqueue(node.left);
                    if (node.right != null) queue.Enqueue(node.right);
                    if (flag)
                        list.Add(node.val);
                    else
                        list.Insert(0, node.val);
                }
                flag = !flag;
                ans.Add(list);
            }
            return ans;
        }

        // https://leetcode.com/problems/find-bottom-left-tree-value/
        public int FindBottomLeftValue(TreeNode root) {
            var ans = 0;
            if (root == null) return ans;

            Queue<TreeNode> queue = new Queue<TreeNode>();
            queue.Enqueue(root);
            while (queue.Count > 0)
            {
                int size = queue.Count;
                for (int i=0; i<size; i++)
                {
                    var node = queue.Dequeue();
                    if (i == 0) ans = node.val;
                    if (node.left != null) queue.Enqueue(node.left);
                    if (node.right != null) queue.Enqueue(node.right);
                }
            }
            return ans;
        }

        // https://leetcode.com/problems/binary-tree-maximum-path-sum/
        public int MaxPathSum(TreeNode root) {
            if (root == null) return 0;
            int[] ans = new int[1] { int.MinValue };
            MaxNodeSum(root, ans);
            return ans[0];
        }

        public int MaxNodeSum(TreeNode root, int[] ans)
        {
            if (root == null) return 0;
            int ls = Math.Max(0, MaxNodeSum(root.left, ans));
            int rs = Math.Max(0, MaxNodeSum(root.right, ans));
            ans[0] = Math.Max(ans[0], ls+rs+root.val);
            return root.val + Math.Max(ls, rs);
        }
    }
}