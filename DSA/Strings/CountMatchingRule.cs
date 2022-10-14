namespace DSA_C.Strings
{
    public class CountMatchingRule
    {
        public void Start()
        {
            IList<IList<string>> items = new List<IList<string>> {
                new List<string> {"phone", "blue", "pixel"},
                new List<string> {"computer", "silver", "lenovo"},
                new List<string> {"phone", "gold", "iphone"}
            };
            string key = "type";
            string value = "phone";
            Console.WriteLine(CountMatches(items, key, value));
        }
        
         int CountMatches(IList<IList<string>> items, string ruleKey, string ruleValue) 
        {
            int idx = 0;
            if (ruleKey == "color") idx = 1;
            else if (ruleKey == "name") idx = 2;
            int ans = 0;
            foreach (List<string> item in items)
            {
                if (item[idx] == ruleValue) ans++;
            }
            return ans;
        }
    }
}