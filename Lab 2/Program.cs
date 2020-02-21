using System;

namespace Lab_2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            var str1 = new MyString("adafaf");
            var str2 = new MyString("123123");
            var str3 = new MyString("!#!$$");
            Text text = new Text();
            text.AddString(str1);
            text.AddString(str2);
            text.AddString(str3);
            //text.RemoveString(1);
            //text.Erase();
            Console.WriteLine(text.MaxString().ToChar);
            Console.WriteLine(text.PercentDigit());
            Console.WriteLine(text.Allsymbols());
        }
    }
}
