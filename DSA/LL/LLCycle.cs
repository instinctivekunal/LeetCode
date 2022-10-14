namespace DSA_C.LL
{
    public class LLCycle
    {
        // https://leetcode.com/problems/add-two-numbers/
        public void Start()
        {
            ListNode A = new ListNode(1, new ListNode(2, new ListNode(3, new ListNode(4, null))));
            Console.WriteLine(HasCycle(A));
        }

        public bool HasCycle(ListNode head) {
            ListNode slow = head;
            ListNode fast = head;
            while (fast != null && fast.next != null)        
            {
                slow = slow.next;
                fast = fast.next.next;
                if (slow == fast)
                    return true;
            }
            return false;
        }

        public bool IsPalindrome(ListNode head) {
            var values = new List<int>();
            while(head != null)
            {
                values.Add(head.val);
                head = head.next;
            }

            for(int i=0; i<values.Count/2; i++)
                if(values[i] != values[values.Count - 1 - i]) 
                    return false;
            return true;
        }
    }
}