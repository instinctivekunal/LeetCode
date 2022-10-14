namespace DSA_C.Recursion
{
    public class SumTriangleFromArray
    {
        public void Start()
        {
            int[] nums = {1,2,3,4,5,6,7,8,9,10};
            SumTriangle(nums, nums.Length);
        }

         void SumTriangle(int[] A, int n)
        {
            if (n<1) return;
            int[] arr = new int[n-1];
            for(int i=0; i<n-1; i++)
            {
                int sum = A[i] + A[i+1]; 
                arr[i] = sum;
            }            
            SumTriangle(arr, n-1);
            Console.WriteLine(string.Join(" ", A));
        }
    }
}