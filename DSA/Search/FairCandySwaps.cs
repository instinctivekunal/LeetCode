namespace Search
{
    public class FairCandySwaps
    {
        public void Start()
        {
            int[] asize = {2};
            int[] bsize = {1,3};
            Console.WriteLine(string.Join("\t",FairCandySwap(asize, bsize)));
        }

         int[] FairCandySwap(int[] aliceSizes, int[] bobSizes) 
        {
            int[] ans = new int[2];
            HashSet<int> set = new HashSet<int>();
            int sumA = 0, sumB = 0;
            foreach(int candies in bobSizes)
            {
                set.Add(candies);
                sumB += candies;
            }
            foreach(int candies in aliceSizes)
            {
                sumA += candies;
            }
            foreach(int candies in aliceSizes)
            {
                int diff = candies - ((sumA-sumB)/2);
                if(set.Contains(diff))
                {
                    ans[0] = candies;
                    ans[1] = diff;
                    break;
                }
            }
            return ans;
        }
    }
}