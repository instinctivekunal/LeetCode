namespace DSA_C.Strings
{
    public class RepeatedSubstringPatternProblem
    {
        // https://leetcode.com/problems/repeated-substring-pattern/
        public void Start()
        {
            string s = "abab";
            Console.WriteLine(RepeatedSubstringPattern(s));
        }

        /*
        We know that if there is a repeating pattern in input s then the first letter of s is the first letter of repeating pattern and the last letter 
        of the s is the last letter of the pattern (e.g. abcabc).
        We will work with this idea further. How do we utilize it to solving our task? Very simply! We will double the input string and store it in 
        string checker. String checker contains now twice as much repetitions of the pattern as the original string s (this should be obvious, if 
        input is abcabc - there are 2 repetitions of abc, then checker will be equal to abcabcabcabc which contains 4 times abc).
        Now we will remove the first and last character of our new string checker. This will 'destroy' 2 of the repeating units inside of it. 
        However, if the original string s contained some repeating pattern, then it had to be there at least twice. Since our checker was made
        like s + s, it must contain at least 4 repetitions of the repeating pattern (in such minimalistic case). And we will destroy only 2 units!
        Therefore if there is a repeating pattern in s, there must be s present in checker after removing first and last character! 
        */
        bool RepeatedSubstringPattern(string s) {
            string checker = (s+s).Substring(1, 2*s.Length-2);
            return checker.Contains(s);
        }
    }
}