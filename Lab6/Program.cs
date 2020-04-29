using System;
using System.Collections.Generic;

namespace Lab6
{
    class Program
    {
        static void Main(string[] args)
        {
            var expressions = new List<Expression>();
            expressions.Add(new Expression(1, 2, -1));
            expressions.Add(new Expression(0, -2, 3));
            foreach(var item in expressions)
            {
                Console.WriteLine(item.GetAnswer());
            }
        }
    }
}
