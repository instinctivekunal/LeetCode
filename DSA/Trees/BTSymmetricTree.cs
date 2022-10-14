namespace DSA_C.Trees
{
    public class BTSymmetricTree
    {
        // https://leetcode.com/problems/symmetric-tree/
        public void Start()
        {
            TreeNode root = new TreeNode (1, null);
            root.left = new TreeNode(2, new TreeNode(3, null, null), new TreeNode(4, null, null));
            root.right = new TreeNode(2, new TreeNode(4, null, null), new TreeNode(3, null, null));
            Console.WriteLine(IsSymmetric(root));            
        }

        bool IsSymmetric(TreeNode root) 
        {
            return root == null || IsSymmetricTree(root.left, root.right);
        }

        bool IsSymmetricTree(TreeNode left, TreeNode right)
        {
            if (left == null || right == null) return left == right;
            if (left.val != right.val) return false;
            return IsSymmetricTree(left.left, right.right) && IsSymmetricTree(left.right, right.left);
        }
    }
}