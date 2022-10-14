namespace DSA_C.Arrays
{
    public class SumOddLengthSubArrays
    {
        // https://leetcode.com/problems/sum-of-all-odd-length-subarrays/
        public void Start()
        {
            int[] arr = {1,4,2,5,3};
            Console.WriteLine(SumOddLengthSubarrays(arr));
        }

        int SumOddLengthSubarrays(int[] arr) {
            int sum = 0;
            int ans = 0;
            int x = 0;
            int n = arr.Length;
            for (int i=0; i<n; i++)
            {
                sum = 0;
                x = 0;
                for (int j=i; j<n; j++)
                {
                    sum += arr[j];
                    x++;
                    if (x%2 != 0)
                        ans += sum;
                }
            }
            return ans;
        }
    }
}