namespace DSA_C.Trees
{
    #nullable disable
    public class BSTSearchVal
    {
        // https://leetcode.com/problems/search-in-a-binary-search-tree/
        public void Start()
        {
            TreeNode root = new TreeNode (4, null);
            root.left = new TreeNode(2, new TreeNode(1, null, null), new TreeNode(3, null, null));
            root.right = new TreeNode(7, null, null);
            var ans = SearchBST(root, 2);
        }

        TreeNode SearchBST(TreeNode root, int val) {
            Stack<TreeNode> stack = new Stack<TreeNode> ();
            stack.Push(root);
            while (stack.Count > 0)
            {
                TreeNode node = stack.Pop();
                if (node.val == val)
                    return node;
                else if (node.val > val && node.left != null) stack.Push(node.left);
                else if (node.val < val && node.right != null) stack.Push(node.right);
            }
            return null;
        }
    }
}