namespace DSA_C.Sort
{
    #nullable disable
    public class LinkedListInsertionSort
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
            ListNode head = new ListNode(-1, new ListNode(5, new ListNode(3, new ListNode(4, new ListNode(0, null)))));
            Console.WriteLine(string.Join(",", InsertionSortList(head)));
        }

         ListNode InsertionSortList(ListNode head) 
        {
            ListNode curr = head?.next;
            ListNode prev = head;
            while(curr != null)
            {
                var temp = curr;
                curr = curr.next;
                if (temp.val < prev.val)
                {
                    prev.next = curr;
                    var newHead = Insert(head, temp);
                    if (newHead!=null)
                        head = newHead;
                }
                else
                    prev = temp;
            }
            return head;        
        }

         ListNode Insert(ListNode head, ListNode node)
        {
            if (node.val<head.val)
            {
                node.next = head;
                return node;
            }

            while(head.next!=null && head.next.val < node.val)
                head = head.next;
            node.next = head.next;
            head.next = node;
            return null;
        }
    }
}