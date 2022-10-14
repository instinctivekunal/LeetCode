namespace DSA_C.Trees
{
    public class BTHeightDepthWidth
    {
        // https://leetcode.com/problems/maximum-depth-of-binary-tree/
        public void Start()
        {
            TreeNode root = new TreeNode (1, new TreeNode(2, new TreeNode(4, new TreeNode(8, null, null), null), new TreeNode(6, null, null)), new TreeNode(3, new TreeNode(5, null, null), new TreeNode(7, new TreeNode(9, null, null), null)));
            var ans = MaxDepth(root);
            Console.WriteLine(ans);
            ans = WidthOfBinaryTree(root);
            Console.WriteLine(ans);
            ans = MinDepth(root);
            Console.WriteLine(ans);
        }

        public int MaxDepth(TreeNode root) {
            if (root == null) return 0;
            int lh = MaxDepth(root.left);
            int rh = MaxDepth(root.right);
            return 1 + Math.Max(lh,rh);
        }

        public int WidthOfBinaryTree(TreeNode root) {
            int ans = 0;
            if (root == null) return ans;

            Queue<(TreeNode, int)> queue = new Queue<(TreeNode, int)>();
            queue.Enqueue((root, 0));
            while (queue.Count > 0)
            {
                int size = queue.Count;
                int pos = queue.Peek().Item2;
                int first=0, last=0;
                for (int i=0; i<size; i++)
                {
                    var (node, curr) = queue.Dequeue();
                    curr -= pos;
                    if (i==0) first = curr;
                    if (i==size-1) last = curr;
                    if (node.left != null)
                        queue.Enqueue((node.left, curr*2+1));
                    if (node.right != null)
                        queue.Enqueue((node.right, curr*2+2));
                }
                ans = Math.Max(ans, last-first+1);
            }
            return ans;
        }

        public int MinDepth(TreeNode root)
        {
            int ans = 0;
            if (root == null) return ans;
            int depth = 1;
            Queue<TreeNode> queue = new Queue<TreeNode>();
            queue.Enqueue(root);
            while (queue.Count>0)
            {
                int size = queue.Count;
                while (size-- > 0)
                {
                    var node = queue.Dequeue();
                    if (node.left == null & node.right == null) return depth;
                    if (node.left != null) queue.Enqueue(node.left);
                    if (node.right != null) queue.Enqueue(node.right);
                }
                depth++;
            }
            return depth;
        }
    }
}