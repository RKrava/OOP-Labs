using System;
using System.Collections.Generic;
using System.Text;

namespace lab8_1
{
    static class Numbers_static
    {
        public static int Number_of_digit(int a)
        {
            return (int)Math.Log10(a) + 1;
        }
    }
}
