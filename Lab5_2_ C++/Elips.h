#pragma once
using namespace std;
#include "Figures.h"
class Elips :
	public Figures
{
    int Semimajor_Axis, Minor_Axis;
    const double PI = 3.14;
public:
    Elips(int semimajor_axis, int minor_axis)
    {
        Semimajor_Axis = semimajor_axis;
        Minor_Axis = minor_axis;
    }
    double Square() override
    {
        return PI * Semimajor_Axis * Minor_Axis;
    }

    double Length() override
    {
        return PI * (Minor_Axis + Semimajor_Axis);
    }
};

