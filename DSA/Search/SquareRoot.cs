namespace Search
{
    public class SquareRoot
    {
        public void Start()
        {
            int num = 2147395599;
            Console.WriteLine(MySqrt(num));
            Console.WriteLine(MySqrt1(num));
        }

         int MySqrt(int x) 
        {
            if (x == 0 || x == 1)
                return x;

            int start=2, end=x/2;
            while(start<=end)
            {                
                int mid = (start+end)/2;
                int target = x/mid;
                Console.WriteLine("S->{0}..{1}..{2}..{3}",start, end, mid, target);
                if (target == mid)
                    return mid;
                if (target < mid)
                    end = mid-1;
                else
                    start = mid+1;
                Console.WriteLine("E->{0}..{1}..{2}..{3}",start, end, mid, target);
            }
            return end;
        }

        // Incorrect Logic
         int MySqrt1(int x) 
        {
            if (x == 0 || x == 1)
                return x;

            int s=2, e=x/2, ans=0;
            while(s<=e)
            {
                int m = (s+e)/2;
                long t=m*m;
                Console.WriteLine("S->{0}..{1}..{2}..{3}",s, e, m, t);
                if (t == x)
                    return m;
                if (t < x)
                {
                    ans = m;
                    s = m+1;
                }
                else
                    e = m-1;
                Console.WriteLine("E->{0}..{1}..{2}..{3}",s, e, m, t);
            }
            return ans;
        }
    }
}