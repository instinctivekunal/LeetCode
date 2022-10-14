namespace DSA_C.Search
{
    public class MedianSortedArray
    {
        public void Start()
        {
            int[] nums1 = {1,2};
            int[] nums2 = {3,4};
            Console.WriteLine(FindMedianSortedArrays(nums1, nums2));
        }

         double FindMedianSortedArrays(int[] nums1, int[] nums2) 
        {
            double ans = 0;
            int[] arr = Merge(nums1, nums2);
            int l = arr.Length;
            if(l%2 == 0)
                ans = (arr[l/2] + arr[l/2-1])/2.0;
            else
                ans = arr[l/2];
            return ans;
        }

         int[] Merge(int[] n1, int[] n2)
        {
            int n=n1.Length, m=n2.Length;
            int[] mix = new int[m+n];
            
            int i=0, j=0, k=0;
            while(i<n && j<m)
            {
                if (n1[i] < n2[j])
                    mix[k++] = n1[i++];
                else
                    mix[k++] = n2[j++];
            }
            while(i<n)
                mix[k++] = n1[i++];
            while(j<m)
                mix[k++] = n2[j++];
            return mix;
        }
    }
}