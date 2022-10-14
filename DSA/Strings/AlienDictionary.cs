namespace DSA_C.Strings
{
    public class AlienDictionary
    {
        // https://leetcode.com/problems/verifying-an-alien-dictionary/
        public void Start()
        {
            string[] words = {"apple","app"};
            string order = "abcdefghijklmnopqrstuvwxyz";
            Console.WriteLine(IsAlienSorted(words, order));
        }

        bool IsAlienSorted(string[] words, string order) {
            for (int i=1; i<words.Length; i++) {
                int idx=0;
                string prev = words[i-1], curr = words[i];
                while (prev[idx] == curr[idx]) {
                    if (idx == prev.Length-1)
                        break;
                    else if (idx == curr.Length-1)
                        return false;
                    idx++;
                }
                if (order.IndexOf(curr[idx]) < order.IndexOf(prev[idx]))
                    return false;
            }
            return true;
        }
    }
}