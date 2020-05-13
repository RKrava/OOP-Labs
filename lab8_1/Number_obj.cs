using System;
using System.Collections.Generic;
using System.Text;

namespace lab8_1
{
    class Number_obj
    {
        public int Number_of_digit(int a)
        {
            return (int)Math.Log10(a) + 1;
        }
    }
}
