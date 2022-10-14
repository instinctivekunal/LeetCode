namespace DSA_C.Arrays
{
    public class MergeSorted
    {
        public void Start()
        {
            int[] nums1 = {3,4,6,0,0,0};
            int[] nums2 = {1,2,5};
            int m = 3;
            int n = 3;
            Merge(nums1, m, nums2, n);
            Console.WriteLine(string.Join(",", nums1));
        }

         void Merge(int[] nums1, int m, int[] nums2, int n) 
        {
            for(int i=0; i<n; i++)
            {
                nums1[m+i] = nums2[i];
            }
            Array.Sort(nums1);
        }
    }
}