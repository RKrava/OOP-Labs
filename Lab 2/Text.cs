using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_2
{
    class Text
    {
        int size;
        int numbersymbols;
        MyString[] myStrings;

        public int Size
        {
            get
            {
                return size;
            }
        }
        public Text()
        {
            size = 0;
        }
        public void AddString(MyString str)
        {
            Array.Resize(ref myStrings, ++size);
            myStrings[size - 1] = str;
        }
        public void RemoveString(int delIndex)
        {
            if (delIndex > size)
            {

            }
            var newData = new MyString[myStrings.Length - 1];
            for (int i = 0; i < delIndex; i++)
            {
                newData[i] = myStrings[i];
            }
            for (int i = delIndex; i < newData.Length; i++)
            {
                newData[i] = myStrings[i + 1];
            }
            myStrings = newData;
            size--;
        }
        public void Erase()
        {
            myStrings = new MyString[0];
            size = 0;
        }
        public MyString MaxString()
        {
            int max = -1;
            var my = new MyString();
            foreach(var item in myStrings)
            {
                if(item.Count() > max)
                {
                    max = item.Count();
                    my = item;
                }
            }
            return my;
        }
        public int Allsymbols()
        {
            int symbols = 0;
            foreach(var item in myStrings)
            {
                symbols += item.Count();
            }
            return symbols;
        }
        private int NumbersinText()
        {
            int numintext = 0;
            foreach(var item in myStrings)
            {
                numintext += item.Numbers();
            }
            return numintext;
        }
        public int PercentDigit()
        {
            return NumbersinText() * 100 / Allsymbols();
        }
    }
}
