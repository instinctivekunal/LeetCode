using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Arrays
{
    public class Intersection
    {
        public static void Start()
        {
            int[] nums1 = {1,2,2,3,4,1};
            int[] nums2 = {1,2,2,5,4,7,1};
            Console.WriteLine(string.Join(",", Intersect(nums1, nums2)));
        }

        static int[] Intersect(int[] nums1, int[] nums2) 
        {
            Array.Sort(nums1);
            Array.Sort(nums2);
            List<int> res = new List<int>();
            int idx1 = 0;
            int idx2 = 0;
            while(idx1 < nums1.Length && idx2 < nums2.Length)
            {
                if(nums1[idx1] == nums2[idx2]){
                    res.Add(nums1[idx1]);
                    idx1++;
                    idx2++;                    
                }
                else if(nums1[idx1] < nums2[idx2]){
                    idx1++;
                }
                else {
                    idx2++;
                }
            }
            return res.ToArray();
        }
    }
}