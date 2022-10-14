namespace DSA_C.Sort
{
    public class RankTransform
    {
        public void Start()
        {
            int[] arr = {37,12,28,9,100,56,80,5,12};
            Console.WriteLine(string.Join(",", ArrayRankTransform(arr)));
        }

         int[] ArrayRankTransform(int[] arr) 
        {
            int[] sorted = new List<int>(arr).Distinct().ToArray();
            Array.Sort(sorted);

            Dictionary<int,int> data = new Dictionary<int,int>();
            for(int i=0; i<sorted.Length; i++)
                data.Add(sorted[i], i+1);
                
            int[] ans = new int[arr.Length];
            for(int i=0; i<arr.Length; i++)        
                ans[i] = data[arr[i]];
            return ans;
        }
    }
}