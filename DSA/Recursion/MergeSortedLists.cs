namespace DSA_C.Recursion
{
    #nullable disable
    public class MergeSortedLists
    {

        public class ListNode {
            public int val;
            public ListNode next;
            public ListNode(int val=0, ListNode next=null) {
                this.val = val;
                this.next = next;
            }
        }

        public void Start()
        {
            ListNode A = new ListNode(1, new ListNode(2, new ListNode(4, null)));
            ListNode B = new ListNode(1, new ListNode(3, new ListNode(4, null)));
            Console.WriteLine(MergeTwoLists(A, B));            
        }

         ListNode MergeTwoLists(ListNode A, ListNode B) {
            if (A == null) return B;
            if (B == null) return A;
            if (A.val < B.val)
            {
                A.next = MergeTwoLists(A.next, B);
                return A;
            }
            else{
                B.next = MergeTwoLists(A, B.next);
                return B;
            }        
        }
    }
}