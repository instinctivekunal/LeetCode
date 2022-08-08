using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DSA_C.Search
{
    public class SplitArrLargestSum
    {
        public static void Start()
        {
            int[] nums = {7,2,5,10,8};
            int m =2;
            Console.WriteLine(SplitArray(nums, m));
        }

        static int SplitArray(int[] nums, int m) 
        { 
            int sum=0;
            foreach(int num in nums)
                sum+=num;
            int start=0, end=sum, mid=0;
            while(start<end)
            {
                mid = start+(end-start)/2;
                Console.WriteLine("S->{0}..{1}..{2}",start, end, mid);
                if (Check(nums, m, mid))
                    end = mid;
                else
                    start = mid+1;
                Console.WriteLine("E->{0}..{1}..{2}",start, end, mid);
            }
            return start;
        }

        static bool Check(int[] nums, int m, int min)
        {
            int sum=0, split=1;
            foreach(int num in nums)
            {
                if(num > min)
                    return false;
                if(sum+num > min)
                {
                    sum = num;
                    split++;
                    if (split>m)
                        return false;
                }
                else
                    sum += num;
            }
            return true;
        }
    }
}