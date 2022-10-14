namespace DSA_C.LL
{
    #nullable disable
    public class DeleteMultiNodes
    {
        // https://leetcode.com/problems/remove-linked-list-elements/
        public void Start()
        {
            // ListNode head = new ListNode(1, new ListNode(3, new ListNode(4, new ListNode(7, new ListNode(7, new ListNode(2, new ListNode(6, null)))))));
            ListNode head = new ListNode(1, new ListNode(2, new ListNode(2, new ListNode(2, null))));
            // ListNode head = new ListNode(1, new ListNode(2, null));
            Console.WriteLine(removeElements(head, 2));
        }

        ListNode removeElements(ListNode head, int val) {
            if (head == null) return null;
            head.next = removeElements(head.next, val);
            return head.val == val ? head.next : head;
        }

        ListNode RemoveElements(ListNode head, int val) {            
            ListNode temp = new ListNode(0);
            ListNode prev = temp;
            temp.next = head;
            ListNode curr = head;
            while (curr != null)
            {              
                if (curr.val == val) {
                    prev.next = curr.next;
                    curr = prev;
                }
                prev = curr;
                curr = curr.next;
            }
            return temp.next;
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