using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Search
{
    public class PerfectSquare
    {
        public static void Start()
        {
            int num = 5;
            Console.WriteLine(IsPerfectSquare(num));
        }

        static bool IsPerfectSquare(int num) 
        {
            if (num == 1)
                return true;            
            return BinarySearch(num, 1, (num/2));
        }

        static bool BinarySearch(int target, int start, int end)
        {
            Console.WriteLine("S->{0}..{1}..{2}",target, start, end);            
            while(start<=end)
            {
                var mid = start + (end-start)/2;
                var div = target/(float)mid;
                if (mid == div)
                    return true;
                if (mid < div)
                    start=mid+1;
                else
                    end=mid-1;
            }
            return false;
        }
    }
}