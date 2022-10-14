namespace DSA_C.Strings
{
    public class FindLongestCommonPrefix
    {
        public void Start()
        {
            string[] strs = new string[] {"flower", "flow", "flight"};
            Console.WriteLine(LongestCommonPrefix(strs));
        }

         string LongestCommonPrefix(string[] strs)
        {
            if (strs == null || strs.Length == 0)
                return "";
            Array.Sort(strs);
            string first = strs[0];
            string last = strs[strs.Length-1];
            int count=0;
            while (count<first.Length)
            {
                if (first[count] == last[count]) count++;
                else break;
            }
            return count == 0 ? "" : first.Substring(0, count);
        }
    }
}