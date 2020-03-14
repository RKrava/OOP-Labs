#pragma once
#include <vector>
#include "MyString.h"

class MyText
{
	vector<MyString> text;

public:
	void AddString(MyString str) {
		text.push_back(str);
	}
	void RemoveString(int delIndex) {
		text.erase(text.begin() + delIndex - 1);
	}
	void Erase() {
		vector<MyString> text1;
		text = text1;
	}
	MyString MaxString() {
		int max = -1;
		MyString my;
		for (int i = 0; i < text.size(); i++) {
			if (text[i].Count() > max) {
				max = text[i].Count();
				my = text[i];
			}
		}
		return my;
	}
	int Allsymbols() {
		int smb = 0;
		for (int i = 0; i < text.size(); i++) {
			smb += text[i].Count();
		}
		return smb;
	}
	int NumbersinText()
	{
		int numintext = 0;
		for (int i = 0; i < text.size(); i++) {
			numintext += text[i].Numbers();
		}
		return numintext;
	}
	int PercentDigit()
	{
		return NumbersinText() * 100 / Allsymbols();
	}
};

