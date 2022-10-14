using System.Text;
namespace DSA_C.Strings
{
    public class StringToIntegerATOI
    {
        public void Start()
        {
            string s = "  0000000000012345678";
            Console.WriteLine(MyAtoi(s));
        }

        int MyAtoi(string s) {
            StringBuilder sb = new StringBuilder();
            bool isNegative = false;
            s = s.Trim();
            for(int i=0; i<s.Length; i++)
            {
                char ch = s[i];
                if (i == 0){
                    if (ch == '+') continue;
                    if (ch == '-') { 
                        isNegative = true;
                        continue;
                    }
                } 
                if (ch >= '0' && ch <= '9')
                    sb.Append(ch);
                else {
                    break;
                }
            }
            string str = sb.ToString().TrimStart('0');
            long ans = 0;
            if (str.Length > 10)
                return (isNegative) ? int.MinValue : int.MaxValue;
            
            if (!string.IsNullOrEmpty(str))
                ans = long.Parse(str);
            if (isNegative) ans *= -1;
            if (ans > int.MaxValue) ans = int.MaxValue;
            if (ans < int.MinValue) ans = int.MinValue; 
            return (int)ans;
        }

        int MyAtoi1(string s) {
            StringBuilder sb = new StringBuilder();
            bool isNegative = false;
            foreach(char ch in s.Trim())
            {
                if (ch >= '0' && ch <= '9')
                    sb.Append(ch);
                else if (sb.Length == 0){
                    if (ch == '+') continue;
                    if (ch == '-') isNegative = true;
                } else {
                    break;
                }
            }
            int ans = int.Parse(sb.ToString());
            if (isNegative) ans *= -1;
            return ans;
        }
    }
}