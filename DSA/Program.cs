using DSA_C.Arrays;
using DSA_C.Search;
using DSA_C.Sort;
using DSA_C.Strings;
using DSA_C.Greedy;
using DSA_C.Recursion;
using DSA_C.LL;
using DSA_C.Trees;
using DSA_C.Graph;
using DSA_C.DP;
using DSA_C.Rest;

namespace DSA
{
    #nullable disable
    class Program
    {
        public static void Main(string[] args)
        {
            var obj = new PermutationLetterCase();
            obj.Start();
        }
    }

    public class MyQueue {
        Stack<int> input, output;
        public MyQueue() {
            input = new Stack<int> ();
            output = new Stack<int> ();        
        }
        
        public void Push(int x) {
            input.Push(x);
        }
        
        public void Pop() {
            Peek();
            output.Pop();
        }
        
        public int Peek() {
            if (output.Count == 0)
            {
                while(input.Count > 0)
                    output.Push(input.Pop());
            }
            return output.Peek();            
        }
        
        public bool Empty() {
            return (input.Count > 0 && output.Count > 0);
        }
    }
}