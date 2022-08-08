using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DSA_C.Sort
{
    public class MergeSortedArray
    {
        public static void Start()
        {
            int[] nums1 = {1};
            int m=1;
            int[] nums2 = {};
            int n=0;
            Merge(nums1, m, nums2, n);
        }

        static void Merge(int[] nums1, int m, int[] nums2, int n) 
        {         
            int i=m+n-1;
            m--;
            n--;
            while(n>=0)
            {
                if (m>=0 && nums1[m] > nums2[n])
                    nums1[i] = nums1[m--];
                else
                    nums1[i] = nums2[n--];
                i--;
            }
        }

        static void Merge1(int[] nums1, int m, int[] nums2, int n) 
        {         
            int i=m-1, j=n-1, k=m+n-1;
            while(i>=0 && j>=0)
            {
                if (nums1[i] < nums2[j])
                    nums1[k--] = nums2[j--];
                else
                    nums1[k--] = nums1[i--];
            }
            while(j>=0)
                nums1[k--] = nums2[j--];
        }

    }
}