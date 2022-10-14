namespace DSA_C.Trees
{
    public class BTDuplicateSubTrees
    {
        public void Start()
        {
            TreeNode root = new TreeNode (1, null);
            root.left = new TreeNode(2, new TreeNode(4, null, null), null);
            root.right = new TreeNode(3, new TreeNode(2, new TreeNode(4, null, null), null),  new TreeNode(4, null, null));
            var ans = FindDuplicateSubtrees(root);
        }

        IList<TreeNode> FindDuplicateSubtrees(TreeNode root) {
            Dictionary<string, int> map = new Dictionary<string, int>();
            IList<TreeNode> ans = new List<TreeNode>();
            FindDuplicatesUsingDfs(root, map, ans);
            return ans;
        }

        string FindDuplicatesUsingDfs(TreeNode root, Dictionary<string, int> map, IList<TreeNode> ans)
        {
            if (root == null) return "N";
            string left = FindDuplicatesUsingDfs(root.left, map, ans);
            string right = FindDuplicatesUsingDfs(root.right, map, ans);

            string parent = root.val + " " + left + " " + right;
            if (map.ContainsKey(parent))
                map[parent] += 1;
            else map.Add(parent, 1);

            if (map[parent] == 2) ans.Add(root);
            return parent;
        }
    }
}