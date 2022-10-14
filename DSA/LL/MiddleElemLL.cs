namespace DSA_C.LL
{
    public class MiddleElemLL
    {
        // https://leetcode.com/problems/middle-of-the-linked-list/
        public void Start()
        {
            ListNode head = new ListNode(1, new ListNode(2, new ListNode(3, new ListNode(4, new ListNode(5, new ListNode(6, null))))));
            Console.WriteLine(MiddleNode(head));
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
    }
}