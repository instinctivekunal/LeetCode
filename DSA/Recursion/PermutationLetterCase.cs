namespace DSA_C.Recursion
{
    public class PermutationLetterCase
    {
        // https://leetcode.com/problems/letter-case-permutation/description
        public void Start()
        {
            string s = "a1b2c3d4e5f6g7h8i9";
            Console.WriteLine(string.Join(" ", LetterCasePermutation(s)));
        }

        IList<string> LetterCasePermutation(string s) {
            List<string> ans = new List<string>();
            BackTrack(ans, 0, s.ToCharArray());
            return ans;
        }

        void BackTrack(List<string> ans, int idx, char[] arr)
        {
            if (idx == arr.Length)
                ans.Add(new string(arr));
            else {
                if (char.IsLetter(arr[idx])) {
                    arr[idx] = char.ToUpper(arr[idx]);
                    BackTrack(ans, idx+1, arr);
                    arr[idx] = char.ToLower(arr[idx]);
                    BackTrack(ans, idx+1, arr);
                }
                else
                    BackTrack(ans, idx+1, arr);
            }
        }
    }
}