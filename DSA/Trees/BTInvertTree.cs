namespace DSA_C.Trees
{
    public class BTInvertTree
    {
        // https://leetcode.com/problems/invert-binary-tree/
        public void Start()
        {
            TreeNode root = new TreeNode (4, null);
            root.left = new TreeNode(2, new TreeNode(1, null, null), new TreeNode(3, null, null));
            root.right = new TreeNode(7, new TreeNode(6, null, null), new TreeNode(9, null, null));
            Console.WriteLine(InvertTree(root));            
        }

        TreeNode InvertTree(TreeNode root) {
            Stack<TreeNode> stack = new Stack<TreeNode> ();
            stack.Push(root);
            while (stack.Count > 0)
            {
                TreeNode node = stack.Pop();
                TreeNode temp = node.left;
                node.left = node.right;
                node.right = temp;

                if (node.left != null) stack.Push(node.left);
                if (node.right != null) stack.Push(node.right);
            }
            return root;
        }
    }
}