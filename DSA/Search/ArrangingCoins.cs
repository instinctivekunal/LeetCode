using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Search
{
    public class ArrangingCoins
    {
        public static void Start()
        {
            int num = 1804289383;
            Console.WriteLine(ArrangeCoins(num));
        }

        static int ArrangeCoins(int n) 
        {
            long start=0, end=n, coins=0, mid=0;
            while(start<=end)
            {
                mid = start + (end-start)/2;
                coins = mid * (mid +1)/2;
                Console.WriteLine("S->{0}..{1}..{2}..{3}",start, end, mid, coins);
                if (n==coins)
                    return (int)mid;
                if (n < coins)
                    end=mid-1;
                else
                    start=mid+1;
                Console.WriteLine("E->{0}..{1}..{2}..{3}",start, end, mid, coins);
            }
            return (int)end;
        }

        static int ArrangeCoins1(int n) 
        {
            int stair=1, count=0;
            while(n>0)            
            {
                n -= stair;
                stair++;
                count++;
            }
            if (n==0)
                return count;
            else
                return count-1;
        
        }
    }
}