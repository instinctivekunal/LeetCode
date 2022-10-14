namespace DSA_C.LL
{
    #nullable disable
    public class ReorderLL
    {
        public void Start()
        {
            ListNode head = new ListNode(1, new ListNode(2, new ListNode(3, new ListNode(4, new ListNode(5, null)))));
            ReorderList(head);
        }

         void ReorderList(ListNode head) {
            if (head == null || head.next == null)
                return;
            ListNode mid = MiddleNode(head);
            ListNode second = ReverseList(mid);
            ListNode first = head;

            while (first != null && second != null)
            {
                ListNode temp = first.next;
                first.next = second;
                first = temp;

                temp = second.next;
                second.next = first;
                second = temp;
            }

            if (first != null) first.next = null;                    
        }

         ListNode MiddleNode(ListNode head) {
            ListNode slow = head; 
            ListNode fast = head;
            while (fast != null && fast.next != null)
            {
                slow = slow.next;
                fast = fast.next.next;
            }
            return slow;
        }

         ListNode ReverseList(ListNode head) {
            if (head == null) return head;

            ListNode prev = null;
            ListNode curr = head;
            ListNode next = head.next;

            while(curr != null)
            {
                curr.next = prev;
                prev = curr;
                curr = next;
                if (next != null)
                    next = next.next;
            }
            
            return prev;
        }
    }
}