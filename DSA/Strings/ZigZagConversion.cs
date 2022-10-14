using System.Text;
namespace DSA_C.Strings
{
    public class ZigZagConversion
    {
        // https://leetcode.com/problems/zigzag-conversion/description/
        public void Start()
        {
            string s = "A";
            int rows = 1;
            Console.WriteLine(Convert(s, rows));
        }

        string Convert(string s, int numRows) {
            if (numRows == 1) return s;
            StringBuilder ans = new StringBuilder();
            int n = s.Length;
            int cycleLen = 2 * numRows - 2;

            for (int i = 0; i < numRows; i++) {
                for (int j = 0; j + i < n; j += cycleLen) {
                    ans.Append(s[j + i]);
                    if (i != 0 && i != numRows - 1 && j + cycleLen - i < n)
                        ans.Append(s[j + cycleLen - i]);
                }
            }
            return ans.ToString();
        }
    }
}