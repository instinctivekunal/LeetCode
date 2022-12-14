namespace DSA_C.Trees
{
    #nullable disable
    public class Node
    {
        public int val;
        public IList<Node> children;
        public Node left;
        public Node right;
        public Node next;

        public Node() {}
        public Node(int _val) {
            val = _val;
        }
        public Node(int _val,IList<Node> _children) {
            val = _val;
            children = _children;
        }
        public Node(int _val, Node _left, Node _right, Node _next) {
            val = _val;
            left = _left;
            right = _right;
            next = _next;
        }
    }
}