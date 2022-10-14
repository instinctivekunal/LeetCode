namespace DSA_C.Arrays
{
    public class PascalTriangle
    {
        public void Start()
        {
            int rows = 10;
            Generate(rows);
            int idx = 3;
            GetRow(idx);
        }

         IList<IList<int>> Generate(int numRows) {
            var ans = new List<IList<int>>(numRows);
            for(int i=0; i<numRows; i++)            
            {
                var row = new int[i+1];
                row[0]=1;
                row[i]=1;
                if (i>1)
                {
                    for(int j=1; j<=i-1; j++)
                        row[j]=ans[i-1][j-1] + ans[i-1][j];
                }                    
                ans.Add(row.ToList());
                Console.WriteLine(string.Join("\t", row.ToList()));
            }
            return ans;
        }

        IList<int> GetRow(int rowIndex) {
            var ans = new List<IList<int>>(rowIndex);
            for(int i=0; i<=rowIndex; i++)            
            {
                var row = new int[i+1];
                row[0]=1;
                row[i]=1;
                if (i>1)
                {
                    for(int j=1; j<=i-1; j++)
                        row[j]=ans[i-1][j-1] + ans[i-1][j];
                }                    
                ans.Add(row.ToList());                
            }
            Console.WriteLine(string.Join("\t", ans[rowIndex].ToList()));
            return ans[rowIndex];
        }

         IList<IList<int>> Generate1(int numRows) {
            IList<IList<int>> ans = new List<IList<int>>();            
            for(int i=0; i<numRows; i++)
            {
                ans.Add(GetIntArray(Math.Pow(11,i)));
            }
            return ans;
        }

         IList<int> GetIntArray(double num)
        {
            Console.WriteLine("{0}", num);
            IList<int> ans = new List<int>();
            while(num > 0)
            {
                ans.Add((int)num%10);
                num = num/10;
            }
            ans.Reverse();
            Console.WriteLine(string.Join("\t", ans));
            return ans;
        }
    }
}