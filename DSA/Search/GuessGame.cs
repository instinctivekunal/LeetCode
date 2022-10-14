namespace Search
{
    public class GuessGame
    {
        public void Start()
        {
            int num = 10;
            Console.WriteLine(GuessNumber(num));
        }

         int GuessNumber(int n)
        {
            int start=1, end=n;
            while(start<=end)
            {                
                int mid = start+(end-start)/2;
                int target = 4; //guess(mid);
                Console.WriteLine("S->{0}..{1}..{2}..{3}",start, end, mid, target);
                if (target == 0)
                    return mid;
                if (target < 0)
                    end = mid-1;
                else
                    start = mid+1;
                Console.WriteLine("E->{0}..{1}..{2}..{3}",start, end, mid, target);
            }
            return -1;
        }
    }
}