namespace DSA_C.Trees
{
    public class BSTValidate
    {
        // https://leetcode.com/problems/validate-binary-search-tree/
        public void Start()
        {
            TreeNode root = new TreeNode (4, null);
            root.left = new TreeNode(2, new TreeNode(1, null, null), new TreeNode(3, null, null));
            root.right = new TreeNode(7, null, null);
            var ans = IsValidBST(root);
        }

        bool IsValidBST(TreeNode root) {
            return IsValidBST(root, long.MinValue, long.MaxValue);
        }

        bool IsValidBST(TreeNode root, long minVal, long maxVal) {
            if (root == null) return true;
            if (root.val <= minVal || root.val >= maxVal) return false;
            return IsValidBST(root.left, minVal, root.val) && IsValidBST(root.right, root.val, maxVal);
        }
    }
}