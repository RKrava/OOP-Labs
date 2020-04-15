using System.Linq;

namespace lab5
{
    class LetterStrings : Strings
    {
        string _str;
        public LetterStrings(string s) : base(s)
        {
            _str = s;
        }
        public void Sort()
        {
            _str = string.Concat(_str.OrderBy(x => x).ToArray()); // лямбда выражение
        }
        public string GetStr()
        {
            return _str;
        }
    }
}
