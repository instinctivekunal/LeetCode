namespace DSA_C.Trees
{
    public class NTPostorderTraversal
    {
        // https://leetcode.com/problems/n-ary-tree-postorder-traversal/
        public void Start()
        {
            Node root = new Node (1, new List<Node> { new Node(3, new List<Node> { new Node(5), new Node(6)}), new Node(2), new Node(4)});
            var ans = Postorder(root);
            Console.WriteLine(string.Join(" ", ans));
        }

        IList<int> Postorder(Node root) {
            var ans = new LinkedList<int>();
            if (root == null) return ans.ToList(); 
            Stack<Node> stack = new Stack<Node>();
            stack.Push(root);
            while (stack.Count > 0)
            {
                var node = stack.Pop();
                ans.AddFirst(node.val);
                if (node.children != null)
                    for (int i=0; i<node.children.Count; i++)
                        stack.Push(node.children[i]);
            } 
            return ans.ToList();
        }
    }
}