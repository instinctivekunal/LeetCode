namespace DSA_C.LL
{
    #nullable disable
    public class DeleteMiddleNodeLL
    {
        // https://leetcode.com/problems/delete-the-middle-node-of-a-linked-list/
        public void Start()
        {
            // ListNode head = new ListNode(1, new ListNode(3, new ListNode(4, new ListNode(7, new ListNode(1, new ListNode(2, new ListNode(6, null)))))));
            // ListNode head = new ListNode(1, new ListNode(2, new ListNode(3, new ListNode(4, null))));
            ListNode head = new ListNode(1, null);
            Console.WriteLine(DeleteMiddle(head));
        }

         ListNode DeleteMiddle(ListNode head) {
            if (head.next == null)
                return null;

            ListNode prev = null;
            ListNode slow = head; 
            ListNode fast = head;
            while (fast != null && fast.next != null)
            {
                prev = slow;
                slow = slow.next;
                fast = fast.next.next;
            }
            
            prev.next = slow.next;
            return head;
        }
    }
}