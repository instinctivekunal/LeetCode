using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Search
{
    public class IntersectionArray
    {
        public static void Start()
        {
            int[] nums1 = {4,9,5};
            int[] nums2 = {9,4,9,8,4};
            Console.WriteLine(string.Join("\t",Intersection(nums1, nums2)));
        }

        static int[] Intersection(int[] nums1, int[] nums2) 
        {
            List<int> ans = new List<int>();
            HashSet<int> set = new HashSet<int>();
            for(int i=0; i<nums1.Length; i++)
            {
                if(!set.Contains(nums1[i]))
                    set.Add(nums1[i]);
            }
            for(int j=0; j<nums2.Length; j++)
            {
                if(set.Contains(nums2[j]))
                    ans.Add(nums2[j]);
            }
            return ans.ToArray();
        }
    }
}