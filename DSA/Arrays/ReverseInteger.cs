namespace DSA_C.Arrays
{
    public class ReverseInteger
    {
        // https://leetcode.com/problems/reverse-integer/description/
        public void Start()
        {
            int x = -287935;
            Console.WriteLine(Reverse(x));
        }

        int Reverse(int x) {
            long ans = 0;
            while (x != 0) {
                ans = (ans*10) + x%10;
                if(ans > Int32.MaxValue || ans < Int32.MinValue) return 0;
                x = x/10;
            }            
            return (int)ans;
        }
    }
}