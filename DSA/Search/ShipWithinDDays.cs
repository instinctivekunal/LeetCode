namespace Search
{
    public class ShipWithinDDays
    {
        public void Start()
        {
            int[] wgt = {1,2,3,4,5,6,7,8,9,10};
            int days = 5;
            Console.WriteLine(ShipWithinDays(wgt, days));
        }

         int ShipWithinDays(int[] weights, int days)
        {
            int start = weights.Max();
            int end = weights.Sum();
            while(start<end)
            {
                int mid = start +(end-start)/2;
                int capacity = 0;
                int ships = 1;
                Console.WriteLine("S->{0}..{1}..{2}",start, end, mid);
                foreach(int wgt in weights)
                {
                    capacity+=wgt;
                    if(capacity>mid)
                    {
                        capacity = wgt;
                        ships+=1;
                    }
                    Console.WriteLine("E1->{0}..{1}..{2}",capacity, wgt, ships);
                }

                if(ships>days)
                    start = mid+1;
                else
                    end = mid;
                Console.WriteLine("E->{0}..{1}..{2}",start, end, mid);
            }
            return start;
        }
    }
}