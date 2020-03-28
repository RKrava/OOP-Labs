using System;
using System.Collections.Generic;
using System.Text;

namespace Lab4
{
    class Strings
    {
        string str;
        int size;
        public Strings()
        {

        }
        public Strings(string s)
        {
            str = s;
        }
        public Strings(Strings s)
        {
            str = s.str;
        }
        public int CountLength()
        {
            size = str.Length;
            return size;
        }
        public string GetStr()
        {
            return str;
        }
        public static Strings operator +(Strings c1, Strings c2)
        {
            return new Strings { str = String.Concat(c1.str,c2.str) };
        }
        public static Strings operator -(Strings c1, char c2)
        {
            var Str = new Strings(c1);
            for (int i = 0; i < Str.str.Length; i++)
            {
                if(Str.str[i] == c2)
                {
                    Str.str = Str.str.Remove(i, 1);        
                }
            }
            return Str;
        }
    }
}
