namespace Search
{
    public class MaxValAtGivenIdx
    {
        public void Start()
        {
            int n=6, idx=1, maxSum=10;
            Console.WriteLine(MaxValue(n, idx, maxSum));
        }

         int MaxValue(int n, int index, int maxSum) 
        {
            int sum = n;
            int l=index, r=index;
            int res = 1;

            while(sum + (r-l+1)<=maxSum)
            {
                Console.WriteLine("S->{0}..{1}..{2}..{3}",sum, l, r, res);
                sum += (r-l+1);
                l=l==0?0:l-1;
                r=r==n-1?r:r+1;
                res++;
                if (l==0 && r==n-1)
                {
                    int steps=0;
                    steps+=(maxSum-sum)/n;
                    sum += (steps*n);
                    res+=steps;
                }
                Console.WriteLine("E->{0}..{1}..{2}..{3}",sum, l, r, res);
            }
            return res;
        }
    }

    
}