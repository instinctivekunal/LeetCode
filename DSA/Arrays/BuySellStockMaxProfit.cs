namespace DSA_C.Arrays
{
    public class BuySellStockMaxProfit
    {
        public void Start()
        {
            int[] prices = {3,3,5,0,0,3,1,4};
            Console.WriteLine(MaxProfit(prices));
            Console.WriteLine(MaxProfitII(prices));
            Console.WriteLine(MaxProfitIII(prices));
        }

        // https://leetcode.com/problems/best-time-to-buy-and-sell-stock/
        int MaxProfit(int[] prices) 
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

        // https://leetcode.com/problems/best-time-to-buy-and-sell-stock-ii/
        int MaxProfitII(int[] prices) 
        {
            int profit = 0;
            if (prices == null || prices.Length <= 1)
                return profit;

            for(int i=1; i<prices.Length; i++)
            {
                if (prices[i] > prices[i-1])
                    profit += prices[i] - prices[i-1];
            }
            return profit;
        }

        // https://leetcode.com/problems/best-time-to-buy-and-sell-stock-iii/
        int MaxProfitIII(int[] prices) 
        {
            if (prices == null || prices.Length <= 1)
                return 0;
            int b1=-prices[0], s1=0, b2=-prices[0], s2=0;
            for(int i=1; i<prices.Length; i++)
            {
                b1 = Math.Max(b1, -prices[i]);
                s1 = Math.Max(s1, b1 + prices[i]);
                b2 = Math.Max(b2, s1 - prices[i]);
                s2 = Math.Max(s2, b2 + prices[i]);
            }
            return s2;
        }

        
    }
}