namespace DSA_C.LL
{
    #nullable disable
    public class CopyLLRandomPointer
    {
        public class Node {
            public int val;
            public Node next;
            public Node random;
            
            public Node(int _val) {
                val = _val;
                next = null;
                random = null;
            }
        }

        public void Start()
        {
            Node A = new Node(0);
            var ans=CopyRandomList(A);
            while (ans != null)
            {
                Console.WriteLine(ans.val);
                ans = ans.next;
            }
        }

        public Node CopyRandomList(Node head) {
            if (head == null) return head;

            Dictionary<Node, Node> ans = new Dictionary<Node, Node>();
            var node = head;
            while (node != null)
            {
                ans.Add(node, new Node(node.val));
                node = node.next;
            }

            node = head;
            while (node != null)
            {
                if (node.next != null) ans[node].next = ans[node.next];
                if (node.random != null) ans[node].random = ans[node.random];
                node = node.next;
            }
            return ans[head];
        }        
    }
}