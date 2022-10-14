namespace DSA_C.Sort
{
    public class SortBySetBits
    {
        public void Start()
        {
            int[] arr = {1024,512,256,128,64,32,16,8,4,2,1};
            Console.WriteLine(string.Join(",", SortByBits(arr)));
        }

         int[] SortByBits(int[] arr) 
        {
            int n = arr.Length;
            int[] ans = new int[n];
            int[] bits = new int[n];
            Array.Sort(arr);

            for(int i=0; i<n; i++)
                bits[i] = CountBits(arr[i]);

            int m=0;
            for(int i=bits.Min(); i<=bits.Max(); i++)
            {
                for(int j=0; j<bits.Length; j++)
                {
                    if(i == bits[j])
                        ans[m++] = arr[j];
                }
            }
            return ans;
        }

         int CountBits(int num)
        {
            int count=0;
            while(num>0)
            {
                count += num&1;
                num >>= 1;
            }
            return count;
        }
    }
}