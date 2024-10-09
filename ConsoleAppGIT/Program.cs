namespace ConsoleAppGIT
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Console.WriteLine(DateTime.Now.ToLongDateString());
        }

        public int sum(int x,int y)
        {
            return x + y;
        }
        public int multiply(int x,int y)
        {
            return x * y;
        }
         public int minus(int x,int y)//done by developer2
        {
            return x - y;
        }
    }
}
