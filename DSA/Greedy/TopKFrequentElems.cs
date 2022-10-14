namespace DSA_C.Greedy
{
    public class TopKFrequentElems
    {
        public void Start()
        {
            int[] nums = {1,1,1,2,2,3};
            int k = 2;
            Console.WriteLine(string.Join(" ", TopKFrequent(nums, k)));
        }

        public int[] TopKFrequent(int[] nums, int k) {
            if (nums.Length == k) return nums;

            Dictionary<int, int> items = new Dictionary<int, int>();
            foreach(int num in nums)
            {
                if (items.ContainsKey(num))
                    items[num] += 1;
                else
                    items.Add(num, 1);
            }

            PriorityQueue<int, int> queue = new PriorityQueue<int, int>(Comparer<int>.Create((a,b) => b-a));
            foreach(int key in items.Keys)
                queue.Enqueue(key, items[key]);

            int[] ans = new int[k];
            for (int i=0; i<k; i++)
                ans[i] = queue.Dequeue();

            return ans;
        }
    }
}