namespace DSA_C.Strings
{
    public class WaysToSplitString
    {
        public void Start()
        {
            string s = "00000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000";
            Console.WriteLine(NumWays(s));
        }

         int NumWays(string s) {
            long mod = 1000000007L;
            long n = s.Length;
            long ones=0;
            foreach (char ch in s)
                if (ch == '1') ones++;
            // Case 1: No of 1s are not in multiples of 3
            if (ones%3 != 0) return 0;
            // Case 2: No 1s at all -> (n-2)(n-1)/2
            if (ones == 0) return  (int)((long)((n-2)*(n-1)/2L)%mod);
            // Case 3: No of 1s % 3 is 0
            ones/=3;
            long part1=0;
            long part2=0;
            long part3=0;
            foreach (char ch in s)
            {
                if (ch =='1') part1++;
                if (part1 == ones) part2++;
                if (part1 == 2*ones) part3++;
            }
            return (int)((part2*part3)%mod);            
        }
    }
}