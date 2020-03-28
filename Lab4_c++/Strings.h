#pragma once
#include <iostream>
#include <string>
using namespace std;

class Strings
{
public:
	string str;
	int size;
	Strings(const Strings& s) {
		str = s.str;
		size = s.size;
	}
	Strings(string s) {
		str = s;
		size = s.size();
	}
	Strings() {
		str = "";
		size = 0;
	}
	int CountLength() {
		return size;
	}
	string GetStr()
	{
		return str;
	}
	Strings operator + (Strings c2)
	{
		return Strings(this->str + c2.str);
	}
	Strings operator - (char c2)
	{
		Strings Str;
		Str.str = this->str;

		for (int i = 0; i < this->size; i++)
		{
			if (Str.str[i] == c2)
			{
				Str.str = Str.str.erase(i, 1);
			}
		}
		return Str;
	}
};

