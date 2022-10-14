namespace DSA_C.Recursion
{
    public class ReverseStringProblem
    {
        public void Start()
        {
            char[] s = {'h','e','l','l','o'};
            ReverseString(s);
        }

         void ReverseString(char[] s)
        {
            Reverse(s, 0);
            Console.WriteLine(string.Join(", ", s));
        }

         void Reverse(char[] str, int i)
        {
            int n=str.Length;
            if(i == n/2)
                return;
            Swap(str, i, n-i-1);
            Reverse(str, i+1);
        }

         void Swap(char[] str, int i, int j)
        {
            char t = str[i];
            str[i] = str[j];
            str[j] = t;
        }
    }
}