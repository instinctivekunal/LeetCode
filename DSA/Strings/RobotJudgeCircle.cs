namespace DSA_C.Strings
{
    public class RobotJudgeCircle
    {
        public void Start()
        {
            string moves = "UDLLRR";            
            Console.WriteLine(JudgeCircle(moves));
        }

          bool JudgeCircle(string moves) 
        {
            int[] o = new int[] {0,0};
            foreach(char ch in moves)        
            {
                if(ch=='U') o[0]++;
                if(ch=='D') o[0]--;
                if(ch=='L') o[1]--;
                if(ch=='R') o[1]++;
            }
            return o[0] == 0 && o[1] == 0;
        }
    }
}