namespace DSA_C.Strings
{
    public class MostSegmentOfOnes
    {
         public void Start()
        {
            string s = "10011";
            Console.WriteLine(CheckOnesSegment(s));
        }

         bool CheckOnesSegment(string s) 
        {
            return !s.Contains("01");
        }

         bool CheckOnesSegmen1(string s) 
        {
            int count = 0;
            int max = int.MinValue;
            foreach(char ch in s)
            {
                if (ch == '1')
                    count++;
                else
                {
                    max = Math.Max(max, count);
                    count=0;
                }
            }
            return Math.Max(max, count) > 1;
        }
    }
}