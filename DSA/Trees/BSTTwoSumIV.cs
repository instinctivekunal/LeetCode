namespace DSA_C.Trees
{
    public class BSTTwoSumIV
    {
        // https://leetcode.com/problems/two-sum-iv-input-is-a-bst/
        public void Start()
        {
            TreeNode root = new TreeNode (4, null);
            root.left = new TreeNode(2, new TreeNode(1, null, null), new TreeNode(3, null, null));
            root.right = new TreeNode(7, null, null);
            var ans = FindTarget(root, 7);
        }

        bool FindTarget(TreeNode root, int k) {
            return Traverse(root, k, new HashSet<int>());
        }
        
        // Recursive
        bool Traverse(TreeNode root, int k, HashSet<int> seen)
        {
            if (root == null) return false;
            if (seen.Contains(k - root.val)) return true;
            seen.Add(root.val);
            return Traverse(root.left, k, seen) || Traverse(root.right, k, seen);
        }

        // Iterative
        bool FindTargetI(TreeNode root, int k) {
            if (root == null) return false;
            Stack<TreeNode> stack = new Stack<TreeNode>();
            HashSet<int> seen = new HashSet<int> ();
            stack.Push(root);
            while (stack.Count > 0)
            {
                var node = stack.Pop();
                if (seen.Contains(k-node.val))
                    return true;
                else {
                    if (node.left != null) stack.Push(node.left);
                    if (node.right != null) stack.Push(node.right);
                }
                seen.Add(node.val);
            }
            return false;
        }
    }
}