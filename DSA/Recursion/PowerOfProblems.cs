namespace DSA_C.Recursion
{
    public class PowerOfProblems
    {
        public void Start()
        {
            int n = 20;
            Console.WriteLine(IsPowerOfFour(n));
        }
        
         bool IsPowerOfTwo(int n)
        {
            if (n == 0) return false;
            if (n == 1) return true;
            if (n%2 != 0) return false;
            return IsPowerOfTwo(n/2);
        }

        // Bit Manipulation
         bool IsPowerOfTwoBit(int n)
        {
            if (n <= 0) return false;
            n -= (n & -n);
            return n == 0;            
        }

         bool IsPowerOfThree(int n)
        {
            if (n <= 1) return n==1;            
            return n%3==0 && IsPowerOfThree(n/3);
        }

         bool IsPowerOfThreeLog(int n)
        {
            // i = log(n) / log(3). If n is exact power then ans should be one.
            return (Math.Log10(n) / Math.Log10(3)) % 1 == 0;            
        }

         bool IsPowerOfFour(int n)
        {
            if (n <= 1) return n==1;
            return n%4==0 && IsPowerOfFour(n/4);
        }

    }
}