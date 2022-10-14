namespace DSA_C.Recursion
{
    #nullable disable
    public class SwapNodesInPairs
    {
         public class ListNode {
            public int val;
            public ListNode next;
            public ListNode(int val=0, ListNode next=null) {
                this.val = val;
                this.next = next;
            }
        }

        public void Start()
        {
            ListNode head = new ListNode(1, new ListNode(2, new ListNode(3, new ListNode(4, new ListNode(5, null)))));
            var ans = SwapPairs(head);
            while (ans != null) {
                Console.WriteLine(ans.val);
                ans = ans.next;
            }
        }

         ListNode SwapPairs(ListNode head) {
            if (head == null || head.next == null)
                return head;
            ListNode next = head.next;
            head.next = SwapPairs(head.next.next);
            next.next = head;
            return next;
        }

         ListNode SwapPairs1(ListNode head) {
            // ListNode dummy = new ListNode(0);
            // ListNode pre = dummy, curr = head;
            // dummy.next = head;
            // while (curr != null && curr.next != null)
            // {
            //     //Swap the nodes
            //     ListNode next = curr.next;
            //     pre.next = next;
            //     curr.next = next.next;
            //     next.next = curr;

            //     pre = curr;
            //     curr = curr.next;
            // }

            // return dummy.next;
            if (head == null || head.next == null)
                return head;
            ListNode next = head.next;
            head.next = SwapPairs(head.next.next);
            next.next = head;
            return next;
        }

         ListNode Swap(ListNode first, ListNode second)
        {
            first.next = second.next;
            second.next = first;
            return second;
        }
    }
}