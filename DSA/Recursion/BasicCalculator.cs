namespace DSA_C.Recursion
{
    public class BasicCalculator
    {
        // https://leetcode.com/problems/basic-calculator/
        public void Start()
        {
            string n = "(1+(4+5+2)-3)+(6+8)";
            Console.WriteLine(Calculate(n));
        }

         int Calculate(string s) 
        {
            if (s == null) return 0;

            int ans = 0;
            int sign = 1, num = 0;
            Stack<int> stack = new Stack<int>();
            stack.Push(sign);

            foreach(char ch in s)
            {
                if (ch >= '0' && ch <= '9')
                    num = num*10 + (ch - '0');
                else if (ch == '+' || ch =='-')
                {
                    ans += sign*num;
                    sign = stack.Peek() * (ch == '+'? 1: -1);
                    num = 0;
                }
                else if (ch == '(')
                    stack.Push(sign);
                else if (ch == ')')
                    stack.Pop();
            }
            ans += sign * num;
            return ans;
        }
    }
}