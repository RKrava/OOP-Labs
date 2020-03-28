using System;
using System.Collections.Generic;
using System.Text;

namespace Lab3
{
    class Matrix
    {
        int[][] myArr;
        int sum;

        public Matrix()
        {
        }
        public void CountSum()
        {
            for (int i = 0; i < myArr.Length; i++)
            {
                for (int j = 0; j < myArr[i].Length; j++)
                {
                    sum += myArr[i][j];
                }
            }
        }
        public int[][] MyArr
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
        public int this[int index]
        {
            get
            {
                int avg = 0;
                for(int i = 0; i < myArr[index].Length; i++)
                {
                    avg += myArr[index][i];
                }
                avg /= myArr[index].Length;
                return avg;
            }
        }
        public int Sum
        {
            get
            {
                CountSum();
                return sum;
            }
        }
    }
}
