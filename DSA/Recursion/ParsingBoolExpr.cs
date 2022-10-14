namespace DSA_C.Recursion
{
    public class ParsingBoolExpr
    {
        // https://leetcode.com/problems/parsing-a-boolean-expression/
        public void Start()
        {
            string n = "&(t,f)";
            Console.WriteLine(ParseBoolExpr(n));
        }

         bool ParseBoolExpr(string expression) {
            Stack<char> stack = new Stack<char>(), cache = new Stack<char>();
            foreach(char c in expression) {
                if (c == ')') {
                    cache.Clear();
                    while (stack.Peek() != '(')
                        cache.Push(stack.Pop());
                    stack.Pop();
                    char cur = stack.Pop();
                    if (cur == '&')
                        stack.Push(cache.Contains('f') ? 'f':'t');
                    else if (cur == '|')
                        stack.Push(cache.Contains('t') ? 't':'f');
                    else
                        stack.Push(cache.Pop() == 't' ? 'f': 't');
                }
                else if (c != ',')
                    stack.Push(c);
            }
            return stack.Pop() == 't' ? true: false;
            
        }
    }
}