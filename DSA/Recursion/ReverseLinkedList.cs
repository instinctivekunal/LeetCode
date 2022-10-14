using DSA_C.LL;

namespace DSA_C.Recursion
{
    #nullable disable
    public class ReverseLinkedList
    {
        public void Start()
        {
            ListNode head = new ListNode(1, new ListNode(2, new ListNode(3, new ListNode(4, new ListNode(5, null)))));
            Console.WriteLine(ReverseList(head));
        }

         ListNode ReverseList(ListNode head) {
            ListNode newHead=null;
            while(head != null)        
            {
                ListNode next = head.next; 
                head.next = newHead;
                newHead = head;
                head = next;
            }
            return newHead;
        }

         ListNode Reverse(ListNode head, ListNode newHead)
        {
            if (head == null)
                return newHead;
            ListNode next = head.next; 
            head.next = newHead;
            return Reverse(next, head);
        }
    }
}