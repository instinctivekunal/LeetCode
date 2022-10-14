namespace DSA_C.Trees
{
    public class NTPreorderTraversal
    {
        // https://leetcode.com/problems/n-ary-tree-preorder-traversal/
        public void Start()
        {
            Node root = new Node (1, new List<Node> { new Node(3, new List<Node> { new Node(5), new Node(6)}), new Node(2), new Node(4)});
            var ans = Preorder(root);
            Console.WriteLine(string.Join(" ", ans));
        }

        IList<int> Preorder(Node root) {
            IList<int> ans = new List<int>();
            if (root == null) return ans; 
            Stack<Node> stack = new Stack<Node>();
            stack.Push(root);
            while (stack.Count > 0)
            {
                var node = stack.Pop();
                ans.Add(node.val);
                if (node.children != null)
                    for (int i=node.children.Count-1; i>=0; i--)
                        stack.Push(node.children[i]);
            }
            return ans;
        }
    }
}