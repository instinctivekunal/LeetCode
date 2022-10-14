namespace DSA_C.Strings
{
    public class GoalParser
    {
        public void Start()
        {
            string cmd = "G()()()()(al)";
            Console.WriteLine(Interpret(cmd));
        }

        string Interpret(string command) 
        {
            return command.Replace("()", "o").Replace("(al)", "al");

            // StringBuilder s = new StringBuilder();
            // for(int i=0; i<command.Length; i++)
            // {
            //     if (command[i] == 'G') s.Append('G');
            //     else if (command[i] == '(')
            //     {
            //         if (command[i+1] == ')') 
            //         {
            //             s.Append('o');
            //             i++;
            //         }
            //         else
            //         {
            //             s.Append("al");
            //             i=i+3;
            //         }
            //     }
            // }
            // return s.ToString();
        }
    }
}