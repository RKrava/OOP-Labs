using System;

namespace Lab5_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Figures elips = new Elips(2,3);
            Figures circle = new Circle(4);
            Console.WriteLine(elips.Length());
            Console.WriteLine(elips.Square());
            Console.WriteLine(circle.Length());
            Console.WriteLine(circle.Square());
        }
    }
}
