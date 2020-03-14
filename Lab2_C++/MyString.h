#pragma once
#include <malloc.h>
#include <vector>
#include <string>
using namespace std;
class MyString
{
	string mystr;
	public:

	void Str(string str) {
		mystr = str;
	}
	int Count() {
		return mystr.size();
	}
	int Numbers() {
		int num = 0;
		for (int i = 0; i < Count(); i++) {
			if (mystr[i] >= '0' && mystr[i] <= '9') {
				num++;
			}
		}
		return num;
	}
};

