namespace DSA_C.LL
{
    #nullable disable
    public class RotateLL
    {
        // https://leetcode.com/problems/rotate-list/description/
        public void Start()
        {
            ListNode A = new ListNode(1, new ListNode(2, new ListNode(3, new ListNode(4, new ListNode(5, null)))));
            var ans=RotateRight(A, 2);
            while (ans != null)
            {
                Console.WriteLine(ans.val);
                ans = ans.next;
            }
        }

        public ListNode RotateRight(ListNode head, int k) {
            if (head == null || head.next == null || k <= 0) 
                return head;
            
            // Calculate Length of the LL
            ListNode end = head;
            int length = 1;
            while (end.next != null) {
                end = end.next;
                length++;
            }
            end.next = head;

            int rotations = k%length; // In case of higher values of K like 1000
            int skip = length - rotations;

            // Go to last node
            ListNode last = head;
            for (int i=0; i<skip-1; i++)
                last = last.next;

            // Rotate the nodes
            head = last.next;
            last.next = null;
            
            return head;
        }

        public ListNode RotateRightTLE(ListNode head, int k) {
            if (head == null || head.next == null) return head;
            for (int i=0; i<k; i++)
            {
                ListNode temp = head;
                while (temp.next.next != null)
                    temp = temp.next;
                ListNode end = temp.next;
                temp.next = null;
                end.next = head;
                head = end;
            }
            return head;
        }
    }
}