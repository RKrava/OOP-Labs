using System;
using System.Collections.Generic;
using System.Text;

namespace Lab5_2
{
    class Circle : Figures
    { 
        private int Radius;

        public Circle(int radius)
        {
            Radius = radius;
        }
        public override double Square()
        {
            return 2 * Math.PI * Radius;
        }

        public override double Length()
        {
            return Math.PI * Math.Pow(Radius,2);
        }
    }
}
