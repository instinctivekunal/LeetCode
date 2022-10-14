namespace DSA_C.Trees
{
    public class BTLeftRightView
    {
        public void Start()
        {
            TreeNode root = new TreeNode (1, new TreeNode(2, null, new TreeNode(5, new TreeNode(6, null, null), null)), new TreeNode(3, null, new TreeNode(7, null, null)));
            var ans = LeftSideView(root);
            Console.WriteLine(string.Join(" ", ans));
            ans = RightSideView(root);
            Console.WriteLine(string.Join(" ", ans));
        }

        public IList<int> LeftSideView(TreeNode root) {
            var ans = new List<int>();
            LeftView(root, ans, 0);
            return ans;
        }

        public void LeftView(TreeNode curr, List<int> ans, int depth)
        {
            if (curr == null) return;
            if (depth == ans.Count) ans.Add(curr.val);
            LeftView(curr.left, ans, depth+1);
            LeftView(curr.right, ans, depth+1);
        }

        public IList<int> RightSideView(TreeNode root) {
            var ans = new List<int>();
            RightView(root, ans, 0);
            return ans;
        }

        public void RightView(TreeNode curr, List<int> ans, int depth)
        {
            if (curr == null) return;
            if (depth == ans.Count) ans.Add(curr.val);
            RightView(curr.right, ans, depth+1);
            RightView(curr.left, ans, depth+1);
        }     
      
    }
}