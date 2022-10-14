namespace DSA_C.Trees
{
    public class BTInorderTraversal
    {
        // https://leetcode.com/problems/binary-tree-inorder-traversal/
        public void Start()
        {
            TreeNode root = new TreeNode (1, null, new TreeNode(2, new TreeNode(3, null, null), null));
            var ans = InorderTraversal(root);
        }

        public IList<int> InorderTraversal(TreeNode root) {
            var ans = new List<int>();
            Stack<TreeNode> stack = new Stack<TreeNode>();
            while (root != null || stack.Count > 0)
            {
                if (root != null) {
                    stack.Push(root);
                    root = root.left;
                }
                else {
                    root = stack.Pop();
                    ans.Add(root.val);
                    root = root.right;
                }
            }
            return ans;
        }
        
        public IList<int> InorderTraversal1(TreeNode root) {
            var ans = new List<int>();
            InorderRecursive(root, ans);
            return ans;
        }

        public void InorderRecursive(TreeNode root, List<int> inOrder)
        {
            if (root == null)
                return;
            
            InorderRecursive(root.left, inOrder);
            inOrder.Add(root.val);
            InorderRecursive(root.right, inOrder);
        }

        public List<int> MorrisInorder(TreeNode root)
        {
            var ans = new List<int>();
            TreeNode curr = root;
            while (curr != null)
            {
                if (curr.left != null)
                {
                    TreeNode prev = curr.left;
                    while (prev.right != null && prev.right != curr)
                        prev = prev.right;
                    
                    if (prev.right == null)
                    {
                        prev.right = curr;
                        curr = curr.left;
                    }
                    else
                    {
                        prev.right = null;
                        ans.Add(curr.val);
                        curr = curr.right;
                    }
                }
                else
                {
                    ans.Add(curr.val);
                    curr = curr.right;
                }
            }
            return ans;
        }
    }
}