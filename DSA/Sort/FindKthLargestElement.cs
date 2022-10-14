namespace DSA_C.Sort
{
    public class FindKthLargestElement
    {
        public void Start()
        {
            int[] nums = {3,2,3,1,2,4,5,5,6};
            int k=4;
            Console.WriteLine(string.Join(",", FindKthLargest(nums, k)));
        }

        public int FindKthLargest(int[] nums, int k) 
        {
            PriorityQueue<int, int> queue = new PriorityQueue<int, int>(new Comparer());
            foreach (int num in nums)
                queue.Enqueue(num, num);
            
            int ans = 0;
            while (k-- > 0) ans = queue.Dequeue();
            return ans;
        }

        public int FindKthLargest1(int[] nums, int k) 
        {
            Array.Sort(nums);
            return nums[^k];
        }

        class Comparer : IComparer<int>
        {
            public int Compare(int n1, int n2)
            {
                return n2-n1;
            }
        }
    }
}