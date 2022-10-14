namespace Search
{
    public class BadVersion
    {
        public void Start()
        {
            int num = 10;
            Console.WriteLine(FirstBadVersion(num));
        }

         int FirstBadVersion(int n)
        {
            int start=1, end=n, mid=1;
            while(start<=end)
            {                
                mid = start+(end-start)/2;
                bool target = true; //IsBadVersion(mid);
                Console.WriteLine("S->{0}..{1}..{2}..{3}",start, end, mid, target);
                if (target == false)
                    start = mid+1;
                else
                    end = mid;                   
                Console.WriteLine("E->{0}..{1}..{2}..{3}",start, end, mid, target);
            }
            return start;
        }
    }
}