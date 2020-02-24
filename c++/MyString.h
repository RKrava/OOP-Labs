#include <iostream>

using namespace std;

class MyString{
	char* mystr = new char[0];
	
	public : void Str(char str[]){
		mystr = str;
	}
};
