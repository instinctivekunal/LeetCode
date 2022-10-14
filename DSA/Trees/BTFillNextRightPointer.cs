namespace DSA_C.Trees
{
    #nullable disable
    public class BTFillNextRightPointer
    {
        // https://leetcode.com/problems/populating-next-right-pointers-in-each-node/
        public void Start()
        {
            Node root = new Node(1, new Node(2, new Node(4, null, null, null), new Node(5, null, null, null), null), 
                new Node(3, new Node(6, null, null, null), new Node(7, null, null, null), null), null);
            //var ans = Connect(root);
            var ansR = ConnectR(root);
        }

        Node Connect(Node root) {
            if (root == null) return root;
            Queue<Node> curr = new Queue<Node>();
            curr.Enqueue(root);
            while (curr.Count > 0)
            {
                int size = curr.Count;
                Queue<Node> next = new Queue<Node>();
                while (size-- > 0)
                {
                    var node = curr.Dequeue();
                    node.next = curr.Count > 0 ? curr.Peek() : null;
                    if (node.left != null) next.Enqueue(node.left);
                    if (node.right != null) next.Enqueue(node.right);
                }
                curr = next;
            }
            return root;
        }

        Node ConnectR(Node root) {
            if (root == null) return root;
            Node left = root.left;
            Node right = root.right;
            while (left != null) {
                left.next = right;
                left = left.right;
                right = right.left;
            }
            ConnectR(root.left);
            ConnectR(root.right);
            return root;
        }
    }
}