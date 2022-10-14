namespace DSA_C.LL
{
    public class DeleteNthNode
    {
        // https://leetcode.com/problems/remove-nth-node-from-end-of-list/
        public void Start()
        {
            ListNode head = new ListNode(1, new ListNode(3, new ListNode(4, new ListNode(7, new ListNode(1, new ListNode(2, new ListNode(6, null)))))));
            // ListNode head = new ListNode(1, new ListNode(2, new ListNode(3, new ListNode(4, null))));
            // ListNode head = new ListNode(1, new ListNode(2, null));
            Console.WriteLine(RemoveNthFromEnd(head, 2));
        }

         ListNode RemoveNthFromEnd(ListNode head, int n)  {
            ListNode start = new ListNode(0);
            ListNode slow = start, fast = start;
            slow.next = head;

            // Move fast in front by n+1 steps
            for (int i=0; i<=n; i++)
                fast = fast.next;

            // Traverse lint maintaining the gap of n
            while (fast != null)
            {
                slow = slow.next;
                fast = fast.next;
            }
            slow.next = slow.next.next;
            return start.next;
        }
    }
}