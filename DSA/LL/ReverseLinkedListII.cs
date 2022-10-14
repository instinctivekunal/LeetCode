namespace DSA_C.LL
{
    #nullable disable
    public class ReverseLinkedListII
    {
        public void Start()
        {
            ListNode head = new ListNode(1, new ListNode(2, new ListNode(3, new ListNode(4, new ListNode(5, null)))));
            Console.WriteLine(ReverseBetween(head, 2, 5));
        }

         ListNode ReverseBetween(ListNode head, int left, int right) {
            if (head == null || head.next == null) return head;

            ListNode dummy = new ListNode(-1);
            dummy.next = head;
            ListNode curr = dummy, prev= null;
            // Finding the node from which reverse should start & save prev node
            for(int i=0; i<left; i++)
            {
                prev = curr;
                curr = curr.next;
            }            
            // Reverse the node from left to right
            ListNode prevR=prev;
            ListNode currR=curr;
            for(int i=left; i<=right; i++)
            {
                ListNode temp = currR.next;
                currR.next = prevR;
                prevR = currR;
                currR = temp;
            }
            prev.next = prevR;
            curr.next = currR;

            return dummy.next;
        }
    }
}