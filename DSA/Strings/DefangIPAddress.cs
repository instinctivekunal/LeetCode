namespace DSA_C.Strings
{
    public class DefangIPAddress
    {
        public void Start()
        {
            string addr = "1.1.1.1";
            Console.WriteLine(DefangIPaddr(addr));
        }

         string DefangIPaddr(string address) 
        {
            return address.Replace(".", "[.]");
        }
    }
}