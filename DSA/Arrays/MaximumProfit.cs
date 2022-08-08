using System.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Arrays
{
    public class MaximumProfit
    {
        public static void Start()
        {
            int[] prices = {7,1,5,3,6,4};
            Console.WriteLine(MaxProfit(prices));
        }

        static int MaxProfit(int[] prices) 
        {
            // The points of interest are the peaks and valleys in the given graph. We need to find the largest peak following the smallest valley. 
            // We can maintain two variables - minprice and maxprofit corresponding to the smallest valley and 
            // maximum profit (maximum difference between selling price and minprice) obtained so far respectively.
            int minprice = Int32.MaxValue;
            int maxprofit = 0;
            for(int i=0; i<prices.Length; i++)
            {
                if (prices[i] < minprice)
                    minprice = prices[i];
                else if (prices[i]-minprice > maxprofit)
                    maxprofit = prices[i]-minprice;
            }
            return maxprofit;
        }
    }
}