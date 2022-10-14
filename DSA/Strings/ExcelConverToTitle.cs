namespace DSA_C.Strings
{
    public class ExcelConverToTitle
    {
        public void Start()
        {
            int col = 665700;         
            Console.WriteLine(ConvertToTitle(col));
        }

         string ConvertToTitle(int columnNumber) 
        {
            string ans = "";
            while(columnNumber != 0)
            {
                columnNumber--;
                ans += (char)(columnNumber%26 + 65);
                columnNumber /= 26;
            }
            return Reverse(ans);
        }

         string Reverse(string str)
        {
            string ans = "";
            for(int i= str.Length-1; i>=0; i--)
            {
                ans += str[i];
            }
            return ans;
        }
    }
}