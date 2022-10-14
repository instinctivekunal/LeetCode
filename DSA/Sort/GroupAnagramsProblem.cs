namespace DSA_C.Sort
{
    public class GroupAnagramsProblem
    {
        public void Start()
        {
            string[] strs = {"eat","tea","tan","ate","nat","bat","eat","tab"};
            var res = GroupAnagrams(strs);
            foreach( var item in res)
                Console.WriteLine(string.Join(",", item));
        }

         IList<IList<string>> GroupAnagrams(string[] strs) 
        {
            IList<IList<string>> ans = new List<IList<string>>();
            if (strs.Length == 1)
                return new List<IList<string>> { new List<string> {strs[0]}};
            Dictionary<string, List<string>> map = new Dictionary<string, List<string>>();
            foreach(string str in strs)
            {
                string sorted = SortString(str);
                if (!map.ContainsKey(sorted))
                    map.Add(sorted, new List<string> {str});
                else
                    map[sorted].Add(str);
            }
            foreach(List<string> vals in map.Values)
                ans.Add(vals);

            return ans;
        }

         string SortString(string input)
        {
            char[] characters = input.ToArray();
            Array.Sort(characters);
            return new string(characters);
        }
    }
}