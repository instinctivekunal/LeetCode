namespace DSA_C.Strings
{
    public class LongPressedName
    {
        public void Start()
        {
            string name = "saeed";
            string typed = "ssaaed";
            Console.WriteLine(IsLongPressedName(name, typed));
        }

         bool IsLongPressedName(string name, string typed) 
        {
            if(name.Equals(typed)) return true;
            if(name.Length > typed.Length) return false;

            int i=0, j=0;
            while(j<typed.Length)
            {
                if(i<name.Length && name[i] == typed[j])
                    i++;
                else if (j == 0 || typed[j] != typed[j-1])
                    return false;
                j++;
            }
            return i == name.Length;
        }

         string RemoveDuplicates(string str)
        {
            HashSet<char> set = new HashSet<char>();
            for(int i=0; i<str.Length; i++)
                set.Add(str[i]);
            return string.Concat(set);
        }
    }
}