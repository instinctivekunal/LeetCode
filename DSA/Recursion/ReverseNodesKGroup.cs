using DSA_C.LL;

namespace DSA_C.Recursion
{
    #nullable disable
    public class ReverseNodesKGroup
    {
        public void Start()
        {
            ListNode head = new ListNode(1, new ListNode(2, new ListNode(3, new ListNode(4, new ListNode(5, null)))));
            var ans = ReverseKGroup(head, 4);
             while (ans != null) {
                Console.WriteLine(ans.val);
                ans = ans.next;
            }
        }

         ListNode ReverseKGroup(ListNode head, int k) {
            ListNode curr = head;
            int count = 0;
            // Find the next k+1 node
            while (curr != null && count != k)
            {
                curr = curr.next;
                count++;
            }
            // If count is equal to K then reverse else append the nodes as is
            if (count == k)
            {
                curr = ReverseKGroup(curr, k);
                while(count-- > 0)
                {
                    ListNode tmp = head.next;
                    head.next = curr;
                    curr = head;
                    head = tmp;
                }
                head = curr;
            }
            return head;
        }
    }
}