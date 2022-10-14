namespace DSA_C.Sort
{
    public class SortArrayByFrequency
    {
        public void Start()
        {
            int[] arr = {-1,1,-6,4,5,-6,1,4,1};
            Console.WriteLine(string.Join(",", FrequencySort(arr)));
        }

         int[] FrequencySort(int[] nums) 
        {
            Array.Sort(nums, (a,b) => b.CompareTo(a));
            Dictionary<int, int> data = new Dictionary<int, int>();
            foreach(int num in nums)
            {
                if(data.ContainsKey(num))
                    data[num] += 1;
                else
                    data.Add(num, 1);
            }

            Dictionary<int, int> sorted = data.OrderBy(m => m.Value).ToDictionary(m=>m.Key, m=>m.Value);
            int k=0;
            foreach(var item in sorted)
            {
                int cnt = item.Value;
                while(cnt > 0)
                {
                    nums[k++] = item.Key;
                    cnt--;
                }
            }
            return nums;
        }
    }
}