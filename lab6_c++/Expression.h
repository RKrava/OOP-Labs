#pragma once
#include <iostream>
#include <string>
#include <conio.h>
using namespace std;
class Expression
{
    double _a, _c, _d;
public:
    Expression(double a, double c, double d)
    {
        _a = a;
        _c = c;
        _d = d;
    }
    void Set_a(double a)
    {
        _a = a;
    }
    void Set_c(double c)
    {
        _c = c;
    }
    void Set_d(double d)
    {
        _d = d;
    }
    double Get_a()
    {
        return _a;
    }
    double Get_c()
    {
        return _c;
    }
    double Get_d()
    {
        return _d;
    }
    double TryGetAnswer()
    {
        try
        {
            if (_d == 0) throw "Divide by Zero!";
            if (_d < 0) throw "Negative square root!";
            if (_c + _a + 1 == 0) throw "Divide by Zero!";
            return (2 * _c - _d * sqrt(42 / _d)) / (_c + _a + 1);
        }
        catch (const char* ex)
        {
            cout << "ERROR: " << ex << endl;
            _getch();
            exit(1);
            return 0;
        }
    }
};