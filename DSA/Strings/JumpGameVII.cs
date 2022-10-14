namespace DSA_C.Strings
{
    public class JumpGameVII
    {
        public void Start()
        {
            string s = "00111010";
            int min = 3;
            int max = 5;
            Console.WriteLine(CanReach(s, min, max));
        }

         bool CanReach(string s, int minJump, int maxJump) 
        {
            if (s[^1] == '1') return false;
            Queue<int> q = new Queue<int>();
            q.Enqueue(0);
            int farthest = 0;
            while (q.Count > 0)
            {
                int i = q.Dequeue();
                int start = Math.Max(farthest, i+minJump);
                int end = Math.Min(i+maxJump, s.Length-1);
                for (int j=start; j<=end; j++)
                {
                    if(s[j]=='0')
                    {
                        q.Enqueue(j);
                        if (j == s.Length -1) return true;
                    }
                }
                farthest = end+1;
            }
            return false;        
        }
    }
}