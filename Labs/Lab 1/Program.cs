using System;
namespace Labs
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 14;
            Handler.Increment(ref x);
            //Console.WriteLine(x);

            int a = 13, b = 12;
            Handler.Comparison(a, b);
            //Console.WriteLine(Handler.Comparison(a, b));
        }
    }
    
}
