namespace DSA_C.Sort
{
    public class HeightCheckerSchool
    {
        public void Start()
        {
            int[] hgts = {1,2,3,4,5};
            Console.WriteLine(string.Join(",", HeightChecker(hgts)));
        }

         int HeightChecker(int[] heights) {
            int[] exp = new List<int>(heights).ToArray();
            Array.Sort(exp);
            int count = 0;
            for(int i=0; i<heights.Length; i++)
            {
                if(heights[i] != exp[i]) count++;
            }
            return count;
        }
    }
}