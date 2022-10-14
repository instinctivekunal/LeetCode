namespace DSA_C.LL
{
    public class MergeKSortedLists
    {
        // https://leetcode.com/problems/add-two-numbers/
        public void Start()
        {
            ListNode A = new ListNode(1, new ListNode(2, new ListNode(3, new ListNode(4, null))));
            Console.WriteLine(MergeKLists(new ListNode[1]));
        }

        public ListNode MergeKLists(ListNode[] lists) {
            SortedDictionary<int, int> sort = new SortedDictionary<int, int>();
            for(int i=0; i<lists.GetLength(0); i++)
                while (lists[i] != null)
                {
                    if (!sort.ContainsKey(lists[i].val))
                        sort.Add(lists[i].val, 1);
                    else
                        sort[lists[i].val]++;
                    lists[i] = lists[i].next;
                }
            ListNode newHead = new ListNode(0), curr = newHead;
            foreach (var item in sort) {
                for (int i=0; i<item.Value; i++) {
                    curr.next = new ListNode(item.Key);
                    curr = curr.next;
                }
            }
            return newHead.next;
        }

    }
}