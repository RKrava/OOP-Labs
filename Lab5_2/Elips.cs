using System;
using System.Collections.Generic;
using System.Text;

namespace Lab5_2
{
    class Elips : Figures
    {
        private int Semimajor_Axis, Minor_Axis;
        public Elips(int semimajor_axis, int minor_axis)
        {
            Semimajor_Axis = semimajor_axis;
            Minor_Axis = minor_axis;
        }
        public override double Square()
        {
            return Math.PI * Semimajor_Axis * Minor_Axis;
        }

        public override double Length()
        {
            return Math.PI * (Minor_Axis + Semimajor_Axis);
        }
    }
}
