using System;

namespace Lab6
{
    class Program
    {
        static void Main(string[] args)
        {
            var expression = new Expression(1,2,-1);
            Console.WriteLine(expression.GetAnswer());
        }
    }
}
