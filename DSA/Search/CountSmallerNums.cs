using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DSA_C.Search
{
    public class CountSmallerNums
    {
        public static void Start()
        {
            int[] nums = {5,2,6,1};
            Console.WriteLine(string.Join(",",CountSmaller(nums)));
        }

        static IList<int> CountSmaller(int[] nums) 
        {
            List<int> ans = new List<int>();
            List<int> sorted = new List<int>();
            for (int i=nums.Length-1; i>=0; i--)
            {
                int pos = BinarySearch(sorted, nums[i]);
                sorted.Insert(pos, nums[i]);
                ans.Add(pos);
            }
            ans.Reverse();      
            return ans;
        }

        static int BinarySearch(List<int> sorted, int target)
        {
            int min=0, max=sorted.Count;
            while(min<max)
            {
                int mid = min + (max-min)/2;
                if(sorted[mid] >= target)
                    max=mid;
                else
                    min=mid+1;
            }
            return max;
        }



        static IList<int> CountSmaller1(int[] nums) 
        {
            int n = nums.Length;
            List<int> ans = new List<int>();
            for (int i=0; i<n; i++)        
            {
                int cnt=0;
                for(int j=i; j<n; j++)
                {
                    if (nums[i]>nums[j]) cnt++;
                }
                ans.Add(cnt);
            }
            return ans;
        }
    }
}