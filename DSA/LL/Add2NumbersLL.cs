namespace DSA_C.LL
{
    public class Add2NumbersLL
    {
        // https://leetcode.com/problems/add-two-numbers/
        public void Start()
        {
            ListNode A = new ListNode(1, new ListNode(2, new ListNode(4, null)));
            ListNode B = new ListNode(1, new ListNode(3, new ListNode(4, null)));
            var ans = AddTwoNumbers(A, B);
            while (ans != null)
            {
                Console.WriteLine(ans.val);
                ans = ans.next;
            }
        }

        private ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            ListNode dummy = new ListNode(0);
            ListNode temp = dummy;
            int carry = 0;
            while (l1 != null || l2 != null || carry == 1)
            {
                int sum = 0;
                if (l1 != null)
                {
                    sum += l1.val;
                    l1 = l1.next;
                }

                if (l2 != null)
                {
                    sum += l2.val;
                    l2 = l2.next;
                }

                sum += carry;
                carry = sum/10;

                ListNode node = new ListNode(sum%10);
                temp.next = node;
                temp = temp.next;
            }
            return dummy.next;
        }
    }
}