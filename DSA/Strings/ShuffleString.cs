namespace DSA_C.Strings
{
    public class ShuffleString
    {
        public void Start()
        {
            string s = "codeleet";
            int[] indices = {4,5,6,7,0,2,1,3};
            Console.WriteLine(RestoreString(s, indices));
        }

         string RestoreString(string s, int[] indices) 
        {
            char[] ans = new char[indices.Length];
            for (int i=0; i<indices.Length; i++)
                ans[indices[i]] = s[i];
            return string.Join("", ans);
        }
    }
}