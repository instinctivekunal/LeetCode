namespace DSA_C.LL
{
    #nullable disable
    public class ReverseLLInPlace
    {
        public void Start()
        {
            ListNode head = new ListNode(1, new ListNode(2, new ListNode(3, new ListNode(4, new ListNode(5, null)))));
            Console.WriteLine(ReverseList(head));
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