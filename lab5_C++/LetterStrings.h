#pragma once
#include "Strings.h"
#include <iostream>
#include <string>
#include <algorithm>

using namespace std;

class LetterStrings :
	public Strings
{
    string _str;
public:
    LetterStrings(string s) : Strings(s)
    {
        _str = s;
    }
    void Sort()
    {
        sort(_str.begin(), _str.end());
    }
    string GetStr()
    {
        return _str;
    }
};

