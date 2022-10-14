namespace DSA_C.Trees
{
    #nullable disable
    using System.Text;
    public class BTSerializeDeserialize
    {
        // https://leetcode.com/problems/invert-binary-tree/
        public void Start()
        {
            TreeNode root = new TreeNode (4, null);
            root.left = new TreeNode(2, new TreeNode(1, null, null), new TreeNode(3, null, null));
            root.right = new TreeNode(7, null, null);

            Codec ser = new Codec();
            Codec deser = new Codec();
            TreeNode ans = deser.deserialize(ser.serialize(root));
        }

        public class Codec {
            #nullable disable
            // Encodes a tree to a single string.
            public string serialize(TreeNode root) {
                if (root == null) return "";
                Queue<TreeNode> q = new Queue<TreeNode>();
                StringBuilder ans = new StringBuilder();
                q.Enqueue(root);
                while (q.Count > 0)
                {
                    var node = q.Dequeue();
                    if (node == null)
                    {
                        ans.Append("n ");
                        continue;
                    }                    
                    ans.Append(node.val + " ");
                    q.Enqueue(node.left);
                    q.Enqueue(node.right);
                }
                return ans.ToString().Trim();
            }

            // Decodes your encoded data to tree.
            public TreeNode deserialize(string data) {
                if (string.IsNullOrEmpty(data)) return null;
                Queue<TreeNode> q = new Queue<TreeNode>();
                var nodes = data.Split(" ");
                TreeNode root = new TreeNode(Convert.ToInt32(nodes[0]));
                q.Enqueue(root);

                for(int i=1; i<nodes.Length; i++)
                {
                    TreeNode parent = q.Dequeue();
                    if (nodes[i] != "n")
                    {
                        TreeNode left = new TreeNode(Convert.ToInt32(nodes[i]));
                        parent.left = left;
                        q.Enqueue(left);
                    }
                    if (nodes[++i] != "n")
                    {
                        TreeNode right = new TreeNode(Convert.ToInt32(nodes[i]));
                        parent.right = right;
                        q.Enqueue(right);
                    }
                }
                return root;
            }
        }
    }
}