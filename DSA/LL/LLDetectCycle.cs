namespace DSA_C.LL
{
    #nullable disable
    public class LLDetectCycle
    {
        // https://leetcode.com/problems/linked-list-cycle-ii/
        public void Start()
        {
            ListNode A = new ListNode(1, new ListNode(2, new ListNode(3, new ListNode(4, null))));
            Console.WriteLine(DetectCycle(A));
        }

        public ListNode DetectCycle(ListNode head)
        {
            // Calculate length of cycle
            int length = CycleLength(head);
            if (length == 0)
                return null;
            
            ListNode f = head;
            ListNode s = head;
            // Move the second pointer till the length of cycle
            for(int i=0; i<length; i++)
                s = s.next;
            
            // Traverse both first & second pointer till they don't match
            while (f != s)
            {
                f = f.next;
                s = s.next;
            }
            return s;        
        }

        public int CycleLength(ListNode head) {
            ListNode slow = head;
            ListNode fast = head;
            while (fast != null && fast.next != null)        
            {
                slow = slow.next;
                fast = fast.next.next;
                if (slow == fast) {
                    // Calculate length
                    ListNode temp = slow;
                    int length = 0;
                    do {
                        temp = temp.next;
                        length++;
                    } while (temp != slow);
                    return length;
                }                    
            }
            return 0;
        }
    }
}