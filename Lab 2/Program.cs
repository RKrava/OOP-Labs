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
            var str4 = new MyString("asdasfdfwfwew123");
            Text text = new Text();
            text.AddString(str1);
            text.AddString(str2);
            text.AddString(str3);
            text.AddString(str4);
            text.MaxString();
            text.PercentDigit();
            text.Allsymbols();
            text.Erase();
            text.RemoveString(1);
        }
    }
}
