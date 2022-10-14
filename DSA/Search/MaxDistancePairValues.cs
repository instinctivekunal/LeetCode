namespace DSA_C.Search
{
    public class MaxDistancePairValues
    {
        public void Start()
        {
            int[] num1 = {55,30,5,4,2};
            int[] num2 = {100,20,10,10,5};
            Console.WriteLine(MaxDistance(num1, num2));

        }

        int MaxDistance(int[] nums1, int[] nums2) {
            int ans = 0;
            for (int i=0; i<nums1.Length; i++) {
                int val = nums1[i];
                int start = 0;
                int end = nums2.Length-1;
                int temp = 0;
                while (start <= end)
                {
                    int mid = start + (end-start)/2;
                    if (val <= nums2[mid]) {
                        temp = mid;
                        start = mid+1;
                    } else
                        end = mid-1;
                }
                ans = Math.Max(ans, temp-i);
            }
            return ans;
        }
    }
}