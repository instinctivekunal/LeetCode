namespace DSA_C.Sort
{
    public class LinkedListMergeSort
    {
        #nullable disable
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
            ListNode head = new ListNode(1, new ListNode(5, new ListNode(3, new ListNode(4, new ListNode(2, null)))));
            var ans = MergeSort(head);
        }

         ListNode MergeSort(ListNode head) 
        {
            if (head.next == null)
                return head;

            ListNode mid = FindMid(head);
            var head1 = mid.next;
            mid.next = null;
            var h1 = MergeSort(head);
            var h2 = MergeSort(head1);
            return MergeSortedList(h1, h2);
        }

         ListNode FindMid(ListNode node)
        {
            var slow = node;
            var fast = node.next;
            while(fast != null && fast.next != null)
            {
                slow = slow.next;
                fast = fast.next.next;
            }
            return slow;
        }

         ListNode MergeSortedList(ListNode h1, ListNode h2)
        {
            ListNode root = new ListNode(int.MinValue);
            var temp = root;

            while(h1 != null && h2 != null)
            {
                if  (h1.val < h2.val)
                {
                    temp.next = h1;
                    h1 = h1.next;
                }
                else
                {
                    temp.next = h2;
                    h2 = h2.next;
                }
                temp = temp.next;
            }

            while (h1 != null)
            {
                temp.next = h1;
                h1 = h1.next;
                temp = temp.next;
            }

            while (h2 != null)
            {
                temp.next = h2;
                h2 = h2.next;
                temp = temp.next;
            }
            return root.next;
        }
    }
}