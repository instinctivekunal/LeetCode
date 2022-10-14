namespace DSA_C.Strings
{
    public class ValidParentheses
    {
        public void Start()
        {
            string s = "([)]{}";
            Console.WriteLine(IsValid(s));
        }

         bool IsValid(string s)
        {
            Stack<char> data = new Stack<char>();
            foreach(char ch in s)
            {
                if (ch == '{' || ch == '(' || ch == '[')                
                    data.Push(ch);
                else if (ch == '}' || ch == ')' || ch == ']')
                {
                    if(data.Count == 0) return false;
                    else if (!IsCorrectPair(data.Pop(), ch)) return false;
                }
            }
            return data.Count == 0;
        }

         bool IsCorrectPair(char o, char c)
        {
            if (o == '(' && c == ')') return true;
            if (o == '{' && c == '}') return true;
            if (o == '[' && c == ']') return true;
            return false;
        }
    }
}