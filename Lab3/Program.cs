using System;

namespace Lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            char[][] arr = new char[][] //jaggedarray зубчатый масив економит память 
            {
                     new char[] {'a','b','c','d'},
                     new char[] {'e','f','g','h'},
            };

            var matrix1 = new Matrix();
            matrix1.MyArr = arr;
            Console.WriteLine(matrix1[1]);
            Console.WriteLine(matrix1.Consonants);
        }
    }
}
