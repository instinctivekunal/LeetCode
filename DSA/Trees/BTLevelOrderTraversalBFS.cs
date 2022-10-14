namespace DSA_C.Trees
{
    public class BTLevelOrderTraversalBFS
    {
        // https://leetcode.com/problems/binary-tree-level-order-traversal/
        public void Start()
        {
            TreeNode root = new TreeNode (1, new TreeNode(2, new TreeNode(4, new TreeNode(8, null, null), null), new TreeNode(6, null, null)), new TreeNode(3, new TreeNode(5, null, null), new TreeNode(7, new TreeNode(9, null, null), null)));
            var ans = LevelOrder(root);
        }

        public IList<IList<int>> LevelOrder(TreeNode root) 
        {
            var ans = new List<IList<int>>();
            if (root == null) return ans;

            Queue<TreeNode> queue = new Queue<TreeNode>();
            queue.Enqueue(root);
            while (queue.Count > 0)
            {
                int size = queue.Count;
                var list = new List<int>();
                while (size-- > 0)
                {
                    var node = queue.Dequeue();
                    if (node.left != null) queue.Enqueue(node.left);
                    if (node.right != null) queue.Enqueue(node.right);
                    list.Add(node.val);
                }
                ans.Add(list);
            }
            return ans;
        }

        public bool IsCousins(TreeNode root, int x, int y) 
        {            
            if (root == null) return false;
            Queue<TreeNode> queue = new Queue<TreeNode>();            
            queue.Enqueue(root);
            bool foundX = false, foundY = false;
            while (queue.Count > 0)
            {
                int size = queue.Count;
                foundX = false; 
                foundY = false;
                while (size-- > 0)
                {
                    var node = queue.Dequeue();
                    if (node.val == x) foundX = true;
                    if (node.val == y) foundY = true;
                    if (node.left != null && node.right != null)
                    {
                        if ((node.left.val == x && node.right.val == y) || (node.left.val == y && node.right.val == x))
                            return false;
                    }
                    if (node.left != null) queue.Enqueue(node.left);
                    if (node.right != null) queue.Enqueue(node.right);
                }
                if (foundX && foundY) return true;
            }
            return false;
        }       
    }
}