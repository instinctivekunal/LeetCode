namespace DSA_C.Trees
{
    #nullable disable
    public class BTContructFromInPre
    {
        // https://leetcode.com/problems/construct-binary-tree-from-preorder-and-inorder-traversal/
        public void Start()
        {
            //TreeNode root = new TreeNode (1, new TreeNode(2, new TreeNode(4, new TreeNode(8, null, null), null), new TreeNode(6, null, null)), new TreeNode(3, new TreeNode(5, null, null), new TreeNode(7, new TreeNode(9, null, null), null)));
            int[] inorder = {9,3,15,20,7};
            int[] preorder = {3,9,20,15,7};
            int[] postorder = {9,15,7,20,3};
            var ans = BuildTree(preorder, inorder);
            var ans1 = BuildTreePost(inorder, postorder);
        }

        public TreeNode BuildTree(int[] preorder, int[] inorder) {
            Dictionary<int, int> map = new Dictionary<int, int>();
            for (int i=0; i<inorder.Length; i++)
                map.Add(inorder[i], i);
            var ans = BuildTree(preorder, 0, preorder.Length-1, inorder, 0, inorder.Length-1, map);
            return ans;
        }

        public TreeNode BuildTree(int[] preorder, int preStart, int preEnd, int[] inorder, int inStart, int inEnd, Dictionary<int, int> map)
        {
            if (preStart > preEnd || inStart > inEnd) return null;
            TreeNode node = new TreeNode(preorder[preStart]);
            int inRoot = map[node.val];
            int numsLeft = inRoot - inStart;

            node.left = BuildTree(preorder, preStart+1, preStart+numsLeft, inorder, inStart, inRoot-1, map);
            node.right = BuildTree(preorder, preStart+numsLeft+1, preEnd, inorder, inRoot+1, inEnd, map);
            return node;
        }

        public TreeNode BuildTreePost(int[] inorder, int[] postorder) {
            Dictionary<int, int> map = new Dictionary<int, int>();
            for (int i=0; i<inorder.Length; i++)
                map.Add(inorder[i], i);
            var ans = BuildTreeInPost(inorder, 0, inorder.Length-1, postorder, 0, postorder.Length-1, map);
            return ans;
        }

        public TreeNode BuildTreeInPost(int[] inorder, int inStart, int inEnd, int[] postorder, int postStart, int postEnd, Dictionary<int, int> map)
        {
            if (inStart > inEnd || postStart > postEnd) return null;
            TreeNode node = new TreeNode(postorder[postEnd]);
            int inRoot = map[node.val];
            int numsLeft = inRoot - inStart;

            node.left = BuildTreeInPost(inorder, inStart, inRoot-1, postorder, postStart, postStart+numsLeft-1, map);
            node.right = BuildTreeInPost(inorder, inRoot+1, inEnd, postorder, postStart+numsLeft, postEnd-1, map);
            return node;
        }
    }
}