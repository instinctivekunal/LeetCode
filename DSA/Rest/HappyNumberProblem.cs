namespace DSA_C.Rest
{
    public class HappyNumberProblem
    {
        // https://leetcode.com/problems/happy-number/
        public void Start()
        {
            int n = 2;
            Console.WriteLine(IsHappy(n));
        }

        bool IsHappy(int n) {
            int slow = n;
            int fast = n;
            do {
                slow = Square(slow);
                fast = Square(Square(fast));
            } while (slow != fast);
            if (slow == 1)
                return true;
            return false;
        }

        int Square(int num)
        {
            int ans = 0;
            while (num > 0) {
                ans += (num%10) * (num%10);
                num /= 10;
            }
            return ans;
        }
    }
}