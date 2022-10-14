namespace DSA_C.Trees
{
    #nullable disable
    public class BTSumLeftLeaves
    {
        // https://leetcode.com/problems/sum-of-left-leaves/
        public void Start()
        {
            TreeNode root = new TreeNode (3, new TreeNode(9, null, null), new TreeNode(20, new TreeNode(15, null, null), new TreeNode(7, null, null)));
            var ans = SumOfLeftLeaves(root);
        }
        
        int SumOfLeftLeaves(TreeNode root)
        {
            return SumOfLeftLeaves(root.left, true) + SumOfLeftLeaves(root.right, false);
        }

        int SumOfLeftLeaves(TreeNode node, bool isLeft)
        {
            if (node == null) return 0;
            if (node.left == null && node.right == null && isLeft)
                return node.val;
            return SumOfLeftLeaves(node.left, true) + SumOfLeftLeaves(node.right, false);
        }

        int SumOfLeftLeavesBFS(TreeNode root) {
            int sum = 0;
            Queue<TreeNode> queue = new Queue<TreeNode>();
            queue.Enqueue(root);
            while (queue.Count > 0)
            {
                TreeNode node = queue.Dequeue();
                if (node.left != null) {
                    if (node.left.left == null && node.left.right == null)
                        sum += node.left.val;
                    queue.Enqueue(node.left);
                }
                if (node.right != null)
                    queue.Enqueue(node.right);
            }
            return sum;
        }
    }
}