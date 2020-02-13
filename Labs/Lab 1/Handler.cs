using System;
using System.Collections.Generic;
using System.Text;

namespace Labs
{
    public class Handler
    {
        public static void Increment(ref int x)
        {
            int m = 1;
            while ((x & m) != 0)
            {
                x &= ~m;
                m <<= 1;
            }
            x |= m;
        }

        public static bool Comparison(int a, int b)
        {
            return (a ^ b) == 0 ? true : false;
        }
    }
}
