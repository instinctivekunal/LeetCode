namespace Search
{
    public class KokoEatingBanana
    {
        public void Start()
        {
            int[] piles = {30,11,23,4,20};
            int h = 6;
            Console.WriteLine(MinEatingSpeed(piles, h));
        }

         int MinEatingSpeed(int[] piles, int h) 
        {
            int start=1;
            int end=piles.Max();
            while(start<end)
            {
                int mid = start+(end-start)/2;
                Console.WriteLine("S->{0}..{1}..{2}",start, end, mid);
                if(Check(piles, mid, h))
                    end=mid;
                else
                    start=mid+1;
                Console.WriteLine("E->{0}..{1}..{2}",start, end, mid);
            }
            return end;
        }

         bool Check(int[] piles, int mid, int h)
        {
            int time=0;
            for(int i=0; i<piles.Length; i++)
            {
                if(piles[i]%mid != 0)
                    time+=((piles[i]/mid) +1);
                else
                    time+=(piles[i]/mid);
            }
            Console.WriteLine("{0}",time);
            if(time<=h)
                return true;
            return false;
        }
    }
}