using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace lab5
{
    class LetterStrings : Strings
    {
        string str;
        public LetterStrings(string s) : base(s)
        {
            str = s;
        }
        public void Sort()
        {
            str = string.Concat(str.OrderBy(x => x).ToArray()); // лямбда выражение
        }
        public string GetStr()
        {
            return str;
        }
    }
}
