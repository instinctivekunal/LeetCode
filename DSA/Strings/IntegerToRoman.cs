using System.Text;
namespace DSA_C.Strings
{
    public class IntegerToRoman
    {
        public void Start()
        {
            int num = 2022;
            Console.WriteLine(IntToRoman(num));
        }

        string IntToRoman(int num) {
            var map = new Dictionary<int, string>
            {
                { 1000, "M" },
                { 900, "CM" },
                { 500, "D" },
                { 400, "CD" },
                { 100, "C" },
                { 90, "XC" },
                { 50, "L" },
                { 40, "XL" },
                { 10, "X" },
                { 9, "IX" },
                { 5, "V" },
                { 4, "IV" },
                { 1, "I" },
            };            
            StringBuilder ans = new StringBuilder();
            foreach(var pair in map)
            {
                while (num >= pair.Key)
                {
                    num -= pair.Key;
                    ans.Append(pair.Value);
                }
            }
            return ans.ToString();
        }

    }
}