using System;

namespace lab8_1
{
    class Program
    {
        delegate int Nof(int a);
        static void Main(string[] args)
        {
            Nof nof = new Nof(Numbers_static.Number_of_digit);
            Console.WriteLine(nof.Invoke(45));
            Number_obj obj = new Number_obj();
            Console.WriteLine(obj.Number_of_digit(45)); 
        }
    }
}
