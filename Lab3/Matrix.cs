using System;
using System.Collections.Generic;
using System.Text;

namespace Lab3
{
    class Matrix
    {
        private char[][] myArr;
        private int consonants;
        public char[][] MyArr
        {
            get
            {
                return myArr;
            }
            set
            {
                myArr = value;
            }
        }
        public char[] this[int index]
        {
            get
            {
                return myArr[index-1];
            }
        }
        public int Consonants
        {
            get
            {
                consonants = ConsonantsCount();
                return consonants;
            }
        }
        int ConsonantsCount()
        {
            int number = 0;
            char[] vowels = { 'a', 'e', 'i', 'u', 'o', 'y'};
            Dictionary<char, int> dict = new Dictionary<char, int>(vowels.Length);
            foreach (char ch in vowels)
                dict.Add(ch, 0);
            for (int i = 0; i < myArr.GetLength(0); i++) {
                foreach (char ch in myArr[i])
                {
                    if (!dict.ContainsKey(ch))
                        number++;
                }
            }
            return number;
        }
    }
}
