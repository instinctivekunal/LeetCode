namespace DSA_C.Trees
{
    #nullable disable
    public class BTPostorderTraversal
    {
        // https://leetcode.com/problems/binary-tree-postorder-traversal/
        public void Start()
        {
            TreeNode p = new TreeNode(8, null, null);
            TreeNode q = new TreeNode(9, null, null);
            TreeNode r = new TreeNode(6, null, null);
            TreeNode root = new TreeNode (1, new TreeNode(2, new TreeNode(4, p, null), r), new TreeNode(3, new TreeNode(5, null, null), new TreeNode(7, q, null)));
            var ans = PostorderTraversal(root);
            Console.WriteLine(DiameterOfBinaryTree(root));
            Console.WriteLine(IsBalanced(root));
            var ans1 = LowestCommonAncestor(root, p, r);
        }

        public IList<int> PostorderTraversal(TreeNode root) {
            var ans = new LinkedList<int>();
            if (root == null) return ans.ToList();

            Stack<TreeNode> stack = new Stack<TreeNode>();
            stack.Push(root);
            while (stack.Count > 0)
            {
                var node = stack.Pop();
                ans.AddFirst(node.val);
                if (node.left != null) stack.Push(node.left);
                if (node.right != null) stack.Push(node.right);                
            }
            return ans.ToList();
        }
        
        public IList<int> PostorderTraversal1(TreeNode root) {
            var ans = new List<int>();
            PostorderRecursive(root, ans);
            return ans;
        }

        public void PostorderRecursive(TreeNode root, List<int> postOrder)
        {
            if (root == null)
                return;

            PostorderRecursive(root.left, postOrder);
            PostorderRecursive(root.right, postOrder);
            postOrder.Add(root.val);
        }

        public int DiameterOfBinaryTree(TreeNode root) 
        {
            int[] diameter = new int[1];
            GetHeight(root, diameter);
            return diameter[0];
        }

        public int GetHeight(TreeNode root, int[] diameter)
        {
            if (root == null) return 0;
            int lh = GetHeight(root.left, diameter);
            int rh = GetHeight(root.right, diameter);
            diameter[0] = Math.Max(diameter[0], lh + rh);
            return 1 + Math.Max(lh, rh);
        }

        public bool IsBalanced(TreeNode root) {
            return DfsHeight(root) != -1;
        }

        public int DfsHeight(TreeNode root)
        {
            if (root == null) return 0;
            int lh = DfsHeight(root.left);
            if (lh == -1) return -1;
            int rh = DfsHeight(root.right);
            if (rh == -1) return -1;
            if (Math.Abs(lh-rh) > 1) 
                return -1;
            return 1 + Math.Max(lh, rh);
        }

        public TreeNode LowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q) {
            if (root == null || root == p || root == q) return root;
            TreeNode left = LowestCommonAncestor(root.left, p, q);
            TreeNode right = LowestCommonAncestor(root.right, p, q);
            if (left == null)
                return right;
            else if (right == null)
                return left;
            else
                return root;
        }

        public bool IsSameTree(TreeNode p, TreeNode q) {
            if (p == null && q == null) return true;
            if (p == null || q == null) return false;
            return ((p.val == q.val) && IsSameTree(p.left, q.left) && IsSameTree(p.right, q.right));
        }
    }
}