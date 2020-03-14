#include <iostream>
#include <malloc.h>

using namespace std;
class MyString
{
	char* mystr = new char[0];
	public :
	
	void Str(const char *str){
		mystr = "dfsfdsf";
	}
	int Count(){
		return _msize(mystr) / sizeof(char);
	}
	int Numbers(){
		int num = 0;
		for(int i = 0; i < Count(); i++){
			if(mystr[i] >= '0' && mystr[i] <= '9'){
				num++;
			}
		}
		return num;
	}
};
