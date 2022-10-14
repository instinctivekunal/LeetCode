namespace DSA_C.Trees
{
    public class BTKthSmallestLargest
    {
         // https://leetcode.com/problems/kth-smallest-element-in-a-bst/
        public void Start()
        {
            TreeNode root = new TreeNode (1, new TreeNode(2, new TreeNode(4, new TreeNode(8, null, null), null), new TreeNode(6, null, null)), new TreeNode(3, new TreeNode(5, null, null), new TreeNode(7, new TreeNode(9, null, null), null)));
            int k =3;
            Console.WriteLine(KthSmallest(root, k));
            
        }

        public int KthSmallest(TreeNode root, int k) {
            int curr = 0;
            Stack<TreeNode> stack = new Stack<TreeNode>();
            while (stack.Count > 0 || root != null)            
            {
                if (root != null)
                {
                    stack.Push(root);
                    root = root.left;
                }
                else
                {
                    root = stack.Pop();
                    if (++curr == k) return root.val;
                    root = root.right;
                }
            }
            return -1;
        }
    }
}