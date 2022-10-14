namespace DSA_C.LL
{
    #nullable disable
    public class RemoveDuplicatesSortedList
    {
        // https://leetcode.com/problems/remove-duplicates-from-sorted-list/
        public void Start()
        {
            // ListNode head = new ListNode(1, new ListNode(3, new ListNode(4, new ListNode(7, new ListNode(7, new ListNode(2, new ListNode(6, null)))))));
            ListNode head = new ListNode(1, new ListNode(2, new ListNode(2, new ListNode(2, null))));
            // ListNode head = new ListNode(1, new ListNode(2, null));
            Console.WriteLine(DeleteDuplicates(head));
        }

        ListNode deleteDuplicates(ListNode head, int val) {
            if (head == null || head.next == null) return null;
            head.next = deleteDuplicates(head.next, val);
            return head.val == head.next.val ? head.next : head;
        }

        ListNode DeleteDuplicates(ListNode head) {
            ListNode curr = head;
            while (curr != null)
            {
                while (curr.next != null && curr.val == curr.next.val)
                    curr.next = curr.next.next;
                curr = curr.next;
            }
            return head;
        }

        ListNode DeleteDuplicates1(ListNode head) {
            ListNode temp = new ListNode(0);
            ListNode prev = temp;
            temp.next = head;
            ListNode curr = head;
            while (curr != null && curr.next != null)
            {              
                if (curr.val == curr.next.val) {
                    prev.next = curr.next;
                    curr = prev;
                }
                prev = curr;
                curr = curr.next;
            }
            return temp.next;
        }
    }
}