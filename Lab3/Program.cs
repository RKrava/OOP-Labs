using System;

namespace Lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] arr = new int[][] //jaggedarray зубчатый масив економит память 
            {
                     new int[] {1,2,3,4},
                     new int[] {5,6,7,8},
            };
            var matrix1 = new Matrix();
            matrix1.MyArr = arr;
            Console.WriteLine(matrix1[1]);
            Console.WriteLine(matrix1.Sum);
        }
    }
}
