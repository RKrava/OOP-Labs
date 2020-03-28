using System;

namespace lab5
{
    class Program
    {
        static void Main(string[] args)
        {
            var ltstr = new LetterStrings("dafasdasd");
            Console.WriteLine(ltstr.GetStr());
            ltstr.Sort();
            Console.WriteLine(ltstr.GetStr());
            Console.WriteLine(ltstr.GetLength());
        }
    }
}
