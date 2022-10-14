namespace DSA_C.Trees
{
    public class BSTInsertVal
    {
        // https://leetcode.com/problems/insert-into-a-binary-search-tree/
        public void Start()
        {
            TreeNode root = new TreeNode (4, null);
            root.left = new TreeNode(2, new TreeNode(1, null, null), new TreeNode(3, null, null));
            root.right = new TreeNode(7, null, null);
            var ans = InsertIntoBST(root, 2);
        }

        TreeNode InsertIntoBST(TreeNode root, int val) {
            if (root == null) return new TreeNode(val);
            TreeNode curr = root;
            while (true){
                if (curr.val <= val) {
                    if (curr.right != null)
                        curr = curr.right;
                    else { 
                        curr.right = new TreeNode(val);
                        break;
                    }
                }
                else {
                    if (curr.left != null)
                        curr = curr.left;
                    else {
                        curr.left = new TreeNode(val);
                        break;
                    }
                }
            }
            return root;
        }
    }
}