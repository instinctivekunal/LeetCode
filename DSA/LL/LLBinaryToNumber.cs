namespace DSA_C.LL
{
    public class LLBinaryToNumber
    {
        // https://leetcode.com/problems/convert-binary-number-in-a-linked-list-to-integer/
        public void Start()
        {
            ListNode A = new ListNode(1, new ListNode(0, new ListNode(0, new ListNode(0, null))));
            Console.WriteLine(GetDecimalValue(A));
        }

        int GetDecimalValue(ListNode head) {
            List<int> nums = new List<int>();
            while (head != null)
            {
                nums.Add(head.val);
                head = head.next;
            }
            nums.Reverse();
            double num = 0;
            for (int i=nums.Count-1; i>=0; i--)
            {
                num += nums[i] * Math.Pow(2,i);
            }
            return (int)num;
        }
    }
}