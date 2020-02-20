using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace Labs
{
    public static class Handler
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
            for (int i = Marshal.SizeOf(a) * 8; i >= 0; i++)
            {
                if (Convert.ToBoolean((a ^ 1 << i) ^ (b ^ 1 << i)))
                    return false;
            }
            return true;
        }
    }
}
