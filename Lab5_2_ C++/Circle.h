#pragma once
using namespace std;
#include "Figures.h"
class Circle :
	public Figures
{
    int Radius;
    double PI = 3.14;
public:
    Circle(int radius)
    {
        Radius = radius;
    }
    double Square() override
    {
        return 2 * PI * Radius;
    }

    double Length() override
    {
        return PI * Radius * Radius;
    }
};

