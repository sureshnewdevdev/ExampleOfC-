namespace ExampleOfC_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = "    This is example    ";
            Console.WriteLine(name.Decoreate());


            string studentName = "raja";
            
            string result = studentName.GetFirstString();


            int n = 100;
            bool res = n.IsEven();
            Console.WriteLine(res);

        }

       
    }
}
