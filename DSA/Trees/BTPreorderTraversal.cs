namespace DSA_C.Trees
{
    public class BTPreorderTraversal
    {
        // https://leetcode.com/problems/binary-tree-preorder-traversal/
        public void Start()
        {
            TreeNode root = new TreeNode (1, null, new TreeNode(2, new TreeNode(3, null, null), null));
            var ans = PreorderTraversal(root);
        }

        public IList<int> PreorderTraversal(TreeNode root) {
            var ans = new List<int>();
            if (root == null) return ans;

            Stack<TreeNode> stack = new Stack<TreeNode>();
            stack.Push(root);
            while (stack.Count > 0)
            {
                var node = stack.Peek();
                ans.Add(node.val);
                stack.Pop();
                if (node.right != null) stack.Push(node.right);
                if (node.left != null) stack.Push(node.left);
            }
            return ans;
        }
        
        public IList<int> PreorderTraversal1(TreeNode root) {
            var ans = new List<int>();
            PreorderRecursive(root, ans);
            return ans;
        }

        public void PreorderRecursive(TreeNode root, List<int> preOrder)
        {
            if (root == null)
                return;

            preOrder.Add(root.val);
            PreorderRecursive(root.left, preOrder);
            PreorderRecursive(root.right, preOrder);
        }
    }
}