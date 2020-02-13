using System;
namespace Labs
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 7;
            Handler.Increment(ref x);
            Console.WriteLine(x);

            int a = 11, b = 11;
            Console.WriteLine(Handler.Comparison(a, b));
        }
    }
    
}
