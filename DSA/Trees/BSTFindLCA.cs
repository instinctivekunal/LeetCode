namespace DSA_C.Trees
{
    #nullable disable
    public class BSTFindLCA
    {
        // https://leetcode.com/problems/lowest-common-ancestor-of-a-binary-search-tree/

        public void Start()
        {
            TreeNode root = new TreeNode (4, null);
            root.left = new TreeNode(2, new TreeNode(1, null, null), new TreeNode(3, null, null));
            root.right = new TreeNode(7, null, null);
            var ans = LowestCommonAncestor(root, new TreeNode(3, null, null), new TreeNode(7, null, null));
        }

        TreeNode LowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q) {
            if (root == null) return null;
            int val = root.val;
            if (val < p.val && val < q.val)
                return LowestCommonAncestor(root.right, p, q);
            if (val > p.val && val > q.val)
                return LowestCommonAncestor(root.left, p, q);
            return root;
        }
    }
}
