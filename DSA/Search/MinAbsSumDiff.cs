namespace Search
{
    public class MinAbsSumDiff
    {
        public void Start()
        {
            int[] nums1 = {1,28,21};
            int[] nums2 = {9,21,20};
            Console.WriteLine(MinAbsoluteSumDiff(nums1, nums2));
        }

         int MinAbsoluteSumDiff(int[] nums1, int[] nums2)
        {
            if (nums1.Length==0) return 0;
            if (nums1.Length==1) return Math.Abs(nums1[0]-nums2[0]);

            double sum=0;
            double maxdiff = int.MinValue;
            double mindiff = int.MaxValue;
            int ele=0, diff=0;
            for(int i=0; i<nums1.Length; i++)
            {
                diff = Math.Abs(nums1[i]-nums2[i]);
                Console.WriteLine("S->{0}..{1}..{2}..{3}",diff, maxdiff, sum, ele);
                if (maxdiff < diff)
                {
                    maxdiff = diff;
                    ele = nums2[i];
                }
                sum+=diff;
                Console.WriteLine("E->{0}..{1}..{2}..{3}",diff, maxdiff, sum, ele);
            }
            if (maxdiff == 0)
                return 0;
            for(int i=0; i<nums1.Length; i++)
            {
                diff = Math.Abs(nums1[i]-ele);
                mindiff=Math.Min(mindiff, diff);
                Console.WriteLine("{0}..{1}",diff, mindiff);
            }
            return (int)((sum-maxdiff+mindiff)%1000000007);
        }
    }
}