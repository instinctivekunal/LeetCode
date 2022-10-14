namespace DSA_C.Recursion
{
    public class CountGoodNumbersProblem
    {
        // https://leetcode.com/problems/count-good-numbers/
        public void Start()
        {
            int n = 4;
            Console.WriteLine(CountGoodNumbers(n));
        }

         int CountGoodNumbers(long n) {
            return (int)(ModuloPower(5, (n+1)/2) * ModuloPower(4, (n/2)) % 1000000007);
        }

         long ModuloPower(int x, long y)
        {
            if (y == 0) return 1;
            if (y == 1) return x;
            if (y%2 == 1)
                return (x * ModuloPower(x, y-1)) % 1000000007;
            long half = ModuloPower(x, y/2);
            return half*half %1000000007;
        }
    }
}