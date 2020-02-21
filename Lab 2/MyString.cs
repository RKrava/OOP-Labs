using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_2
{
    class MyString
    {
        char[] mystring;
        
        public char[] ToChar
        {
            get
            {
                return mystring;
            }
        }
        public MyString(char[] ch)
        {
            mystring = ch;
        }
        public MyString(string str)
        {
            mystring = str.ToCharArray();
        }
        public MyString()
        {
            
        }
        public int Count()
        {
            return mystring.Length;
        }
        public int Numbers()
        {
            int num = 0;
            for(int i = 0; i < mystring.Length; i++)
            {
                if (char.IsDigit(mystring[i]))
                {
                    num++;
                }
            }
            return num;
        }
    }
}
