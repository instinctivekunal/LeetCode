namespace DSA_C.Sort
{
    public class AssignCookies
    {
        public void Start()
        {
            int[] nums1 = {1,2};
            int[] nums2 = {1,2,3};
            Console.WriteLine(FindContentChildren(nums1, nums2));
        }

         int FindContentChildren(int[] g, int[] s) 
        {
            Array.Sort(g);
            Array.Sort(s);
            int child = 0;
            for(int j=0; child<g.Length && j<s.Length; j++)
            {
                if(g[child] <= s[j]) child++;                
            }
            return child;
        }
    }
}