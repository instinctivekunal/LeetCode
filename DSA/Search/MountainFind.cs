namespace DSA_C.Search
{
    public class MountainFind
    {
        class MountainArray {
            public int Get(int index) {return 0;}
            public int Length() { return 0; }
        }

        public void Start()
        {
            int[] nums = {7,2,5,10,8};
            int target =2;
            Console.WriteLine(FindInMountainArray(target, new MountainArray()));
        }

         int FindInMountainArray(int target, MountainArray MA) 
        {
            int n=MA.Length()-1;
            int l=0, r=n;
            // Find Peak index
            while(l<r)
            {
                int m = l + (r-l)/2;
                if(MA.Get(m) < MA.Get(m+1))
                    l=m+1;
                else
                    r=m;
            }
            int peak=l;

            //Binary Search from start to peak
            l=0;
            r=peak;
            while(l<=r)
            {
                int m = l + (r-l)/2;
                if(MA.Get(m) < target)
                    l = m+1;
                else if(MA.Get(m) > target)
                    r = m-1;
                else
                    return m;
            }

            //Binary Search from peak to end
            l=peak;
            r=n;
            while(l<=r)
            {
                int m = l + (r-l)/2;
                if(MA.Get(m) < target)
                    r = m-1;
                else if(MA.Get(m) > target)
                    l = m+1;
                else
                    return m;
            }     

            return -1;
        }        
    }
}